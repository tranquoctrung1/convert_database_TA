using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase.Action
{
    public class ConvertSiteAction
    {
        public int ConvertSite()
        {
            GetSiteOldDBACtion getSiteOldDBACtion = new GetSiteOldDBACtion();

            List<t_Sites> listOld = getSiteOldDBACtion.GetOldSites();

            List<t_Site_Sites> listNew = new List<t_Site_Sites>();

            foreach(var item in listOld)
            {
                t_Site_Sites el = new t_Site_Sites();

                el.Id = item.SiteId;
                el.Location = item.SiteAliasName;
                el.Address = item.Location;
                el.Company = item.DisplayGroup;
                el.Longitude = item.Longitude;
                el.Latitude = item.Latitude;

                listNew.Add(el);
            }

            InsertSiteNewDBAction insertSiteNewDBAction = new InsertSiteNewDBAction();

            int nRows = insertSiteNewDBAction.Insert(listNew);

            return nRows;
        }
    }
}
