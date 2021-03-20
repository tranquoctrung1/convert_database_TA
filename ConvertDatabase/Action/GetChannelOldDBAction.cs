using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class GetChannelOldDBAction
    {
        public List<t_Channel_Configurations> GetChannelConfiguration()
        {
            tawaco2Entities context = new tawaco2Entities();

            return context.t_Channel_Configurations.OrderBy(c => c.ChannelId).ToList();
        }
    }
}
