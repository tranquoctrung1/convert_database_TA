using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class GetSiteOldDBACtion
    {
       
       public List<t_Sites> GetOldSites()
       {
            tawaco2Entities context = new tawaco2Entities();

            return context.t_Sites.OrderBy(s => s.SiteId).ToList();
       }
    }
}
