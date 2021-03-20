using ConvertDatabase.ConnectDB;
using ConvertDatabase.Model;
using ConvertDatabase.Statis;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class InsertDataLoggerTableNewDBAction
    {
        public int Insert(string channel, List<DataLoggerModel> list)
        {
            int nRows = 0;

            Connect connect = new Connect(StatisNameDatabase.tmptawaco);

            double length = list.Count / 1000;
            int extra = list.Count % 1000;

            int total = int.Parse( Math.Ceiling(length).ToString());

            if(extra > 0)
            {
                total += 1;
            }

            for(int i = 0; i< total; i++)
            {
                List<DataLoggerModel> temp = new List<DataLoggerModel>();

                if (i != total - 1 )
                {
                    temp = list.GetRange(i * 1000, 1000);
                }
                else
                {
                    temp = list.GetRange(i * 1000, extra);
                }

                string sqlQuery = $"insert into t_Data_{channel} values ";

                for(int j =0; j < temp.Count -1;j ++)
                {
                    sqlQuery += $"('{temp[j].TimeStamp}', '{temp[j].Value}'),";
                }

                sqlQuery += $"('{temp[temp.Count - 1].TimeStamp}', '{temp[temp.Count - 1].Value}')";

                try
                {
                    connect.Connected();

                    nRows += connect.ExcuteNonQuery(sqlQuery);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.DisConnected();
                }

            }
            return nRows;

           
        }
    }
}
