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
    public class GetDataLoggerTableOlDBAction
    {
        public List<DataLoggerModel> GetDataLogger(string channel)
        {
            List<DataLoggerModel> list = new List<DataLoggerModel>();

            Connect connect = new Connect(StatisNameDatabase.tawaco2);

            try
            {
                string sqlQuery = $"select TimeStamp, Value from t_Data_Logger_{channel}";

                connect.Connected();

                SqlDataReader reader = connect.Select(sqlQuery);

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        DataLoggerModel el = new DataLoggerModel();

                        try
                        {
                            el.TimeStamp = DateTime.Parse(reader["TimeStamp"].ToString());
                        }
                        catch(Exception ex)
                        {
                            el.TimeStamp = null;
                        }
                        try
                        {
                            el.Value = double.Parse(reader["Value"].ToString());
                        }
                        catch(Exception ex)
                        {
                            el.Value = null;
                        }

                        list.Add(el);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connect.DisConnected();
            }

            return list;
        }
    }
}
