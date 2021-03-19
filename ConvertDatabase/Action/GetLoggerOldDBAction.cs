using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class GetLoggerOldDBAction
    {
        public List<t_Logger_Configurations> GetLoggerOld()
        {
            tawaco2Entities context = new tawaco2Entities();

            return context.t_Logger_Configurations.OrderBy(l => l.LoggerId).ToList();
        }
    }
}
