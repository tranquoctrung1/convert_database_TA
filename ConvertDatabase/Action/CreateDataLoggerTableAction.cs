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
    public class CreateDataLoggerTableAction
    {
        public int CreateDataLoggerTable(List<string> channels)
        {
            int nRows = 0;

            Connect connect = new Connect(StatisNameDatabase.tmptawaco);

            string sqlQuery = $"";

            foreach(string channel in channels)
            {
                sqlQuery += $"create table t_Data_{channel} (TimeStamp datetime, Value float) ";
            }

            try
            {
                connect.Connected();

                nRows = connect.ExcuteNonQuery(sqlQuery);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connect.DisConnected();
            }

            return nRows;
        }
    }
}
