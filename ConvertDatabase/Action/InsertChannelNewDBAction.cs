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
    public class InsertChannelNewDBAction
    {
        public int Insert(List<t_Devices_ChannelsConfigs> list)
        {
            int nRows = 0;

            if(list.Count > 0)
            {
                string sqlQuery = $"insert into t_Devices_ChannelsConfigs (Id, LoggerId, Name, Unit) values ";

                for (int i = 0; i < list.Count - 1; i++)
                {
                    sqlQuery += $"('{list[i].Id}', '{list[i].LoggerId}', N'{list[i].Name}', '{list[i].Unit}'),";
                }

                sqlQuery += $"('{list[list.Count - 1].Id}', '{list[list.Count - 1].LoggerId}', N'{list[list.Count - 1].Name}', '{list[list.Count - 1].Unit}')";

                Connect connect = new Connect(StatisNameDatabase.tmptawaco);

                try
                {
                    connect.Connected();

                    nRows = connect.ExcuteNonQuery(sqlQuery);
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
