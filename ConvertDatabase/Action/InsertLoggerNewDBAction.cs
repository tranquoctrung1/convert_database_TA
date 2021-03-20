using ConvertDatabase.ConnectDB;
using ConvertDatabase.Statis;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class InsertLoggerNewDBAction
    {

        public int Insert(List<t_Devices_Loggers> list)
        {
            int nRow = 0;

            Connect connect = new Connect(StatisNameDatabase.tmptawaco);

            string sqlQuery = $"insert into t_Devices_Loggers (Serial) values";

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if(list[i].Serial != "")
                    {
                        sqlQuery += $"('{list[i].Serial}'),";
                    }
                }
                sqlQuery += $"('{list[list.Count - 1].Serial}')";
            }

            try
            {
                connect.Connected();

                nRow = connect.ExcuteNonQuery(sqlQuery);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connect.DisConnected();
            }
            return nRow;
        }
    }
}
