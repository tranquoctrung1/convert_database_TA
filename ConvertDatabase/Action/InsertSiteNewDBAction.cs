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
    public class InsertSiteNewDBAction
    {
        public int Insert(List<t_Site_Sites> listNew)
        {
            int nRow = 0;

            Connect connect = new Connect(StatisNameDatabase.tmptawaco);

            string sqlQuery = $"insert into t_Site_Sites (Id, Location, Longitude, Latitude, Company, Adrdress) values";

            if(listNew.Count > 0)
            {
                for(int i = 0; i < listNew.Count - 1; i++)
                {
                    sqlQuery += $"('{listNew[i].Id}', N'{listNew[i].Location}', '{listNew[i].Longitude}', '{listNew[i].Latitude}', N'{listNew[i].Company}', N'{listNew[i].Address}'),";
                }
                sqlQuery += $"('{listNew[listNew.Count - 1].Id}', N'{listNew[listNew.Count - 1].Location}', '{listNew[listNew.Count - 1].Longitude}', '{listNew[listNew.Count - 1].Latitude}', N'{listNew[listNew.Count - 1].Company}', N'{listNew[listNew.Count - 1 ].Address})";
            }

            try
            {
                connect.Connected();

                nRow = connect.ExcuteNonQuery(sqlQuery);
            }
            catch(SqlException ex)
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
