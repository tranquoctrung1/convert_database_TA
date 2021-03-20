using ConvertDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class ConvertTableLoggerAction
    {
      public int CovertTableLogger()
      {
            int nRows = 0;

            GetDataLoggerTableOlDBAction getDataLoggerTableOlDBAction = new GetDataLoggerTableOlDBAction();

            GetChannelOldDBAction getChannelOldDBAction = new GetChannelOldDBAction();

            List<t_Channel_Configurations> list = getChannelOldDBAction.GetChannelConfiguration();

            InsertDataLoggerTableNewDBAction insertDataLoggerTableNewDBAction = new InsertDataLoggerTableNewDBAction();



            foreach (var item in list)
            {
                List<DataLoggerModel> temp = getDataLoggerTableOlDBAction.GetDataLogger(item.ChannelId);

                nRows += insertDataLoggerTableNewDBAction.Insert(item.ChannelId, temp);
            }

            return nRows;
      }


    }
}
