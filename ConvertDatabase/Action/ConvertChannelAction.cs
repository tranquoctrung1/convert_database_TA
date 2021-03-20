using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class ConvertChannelAction
    {
        public int ConvertChannel()
        {
            int nRows = 0;

            GetChannelOldDBAction getChannelOldDBAction = new GetChannelOldDBAction();

            List<t_Channel_Configurations> list = getChannelOldDBAction.GetChannelConfiguration();

            InsertChannelNewDBAction insertChannelNewDBAction = new InsertChannelNewDBAction();

            List<t_Devices_ChannelsConfigs> listNew = new List<t_Devices_ChannelsConfigs>();

            List<string> listChannel = new List<string>();
                 
            foreach(var item in list)
            {
                t_Devices_ChannelsConfigs el = new t_Devices_ChannelsConfigs();

                el.Id = item.ChannelId;
                el.LoggerId = item.LoggerId;
                el.Name = item.ChannelName;
                el.Unit = item.Unit;

                listChannel.Add(item.ChannelId);

                listNew.Add(el);
            }

            nRows += insertChannelNewDBAction.Insert(listNew);

            CreateDataLoggerTableAction createDataLoggerTableAction = new CreateDataLoggerTableAction();

            nRows += createDataLoggerTableAction.CreateDataLoggerTable(listChannel);


            return nRows;
        }
    }
}
