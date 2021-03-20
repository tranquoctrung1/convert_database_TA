using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class ConvertLoggerAction
    {
        public int ConvertLogger()
        {
            int nRows = 0;

            GetLoggerOldDBAction getLoggerOldDBAction = new GetLoggerOldDBAction();

            List<t_Logger_Configurations> listOld = getLoggerOldDBAction.GetLoggerOld();

            List<t_Devices_Loggers> listLoggerNew = new List<t_Devices_Loggers>();
            List<t_Devices_SitesConfigs> listSiteConfig = new List<t_Devices_SitesConfigs>();

            foreach(var item in listOld)
            {
                t_Devices_Loggers el = new t_Devices_Loggers();
                t_Devices_SitesConfigs el2 = new t_Devices_SitesConfigs();

                el.Serial = item.LoggerId;

                el2.Id = item.LoggerId;
                el2.SiteId = item.SiteId;
                el2.Tel = item.TelephoneNumber;
                if(item.Pressure1 != null)
                {
                    el2.Pressure = item.Pressure1;
                }
                if(item.Pressure2 != null)
                {
                    el2.Pressure1 = item.Pressure2;

                }
                if(item.ForwardFlow != null)
                {
                    el2.Forward = item.ForwardFlow;

                }
                if(item.ReverseFlow != null)
                {
                    el2.Reverse = item.ReverseFlow;

                }
                el2.Interval = item.Interval == null ? 15 : item.Interval;
                el2.BeginTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddHours((double)item.StartHour == null ? 0 : (double)item.StartHour);
                el2.DelayTime = item.TimeDelayAlarm == null ? 60 : item.TimeDelayAlarm;

                listLoggerNew.Add(el);
                listSiteConfig.Add(el2);
            }
            InsertLoggerNewDBAction insertLoggerNewDBAction = new InsertLoggerNewDBAction();
            InsertSiteConfigNewDBAction insertSiteConfigNewDBAction = new InsertSiteConfigNewDBAction();

            nRows += insertLoggerNewDBAction.Insert(listLoggerNew);
            nRows += insertSiteConfigNewDBAction.Insert(listSiteConfig);


            return nRows;
        }
    }
}
