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
    public class InsertSiteConfigNewDBAction
    {
        public int Insert(List<t_Devices_SitesConfigs> list)
        {
            int nRow = 0;

            Connect connect = new Connect(StatisNameDatabase.tmptawaco);

            string sqlQuery = $"insert into t_Devices_SitesConfigs (Id, SiteId, Tel, Pressure, Forward, Reverse, Interval, BeginTime, Pressure1, DelayTime) values";

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    sqlQuery += $"('{list[i].Id}', '{list[i].SiteId}', '{list[i].Tel}', '{list[i].Pressure}', '{list[i].Forward}', '{list[i].Reverse}', '{list[i].Interval}', '{list[i].BeginTime}', '{list[i].Pressure1}', '{list[i].DelayTime}'),";
                }
                sqlQuery += $"('{list[list.Count - 1].Id}', '{list[list.Count - 1].SiteId}', '{list[list.Count - 1].Tel}', '{list[list.Count - 1].Pressure}', '{list[list.Count - 1].Forward}', '{list[list.Count - 1].Reverse}', '{list[list.Count - 1].Interval}', '{list[list.Count - 1].BeginTime}', '{list[list.Count - 1].Pressure1}', '{list[list.Count - 1].DelayTime}')";
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
