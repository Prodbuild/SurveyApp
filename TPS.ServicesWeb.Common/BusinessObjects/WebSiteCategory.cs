using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS.ServicesWeb.Common.BusinessObjects
{
    public class WebSiteCategory
    {
        public string Name { get; set; }
        public List<WebSite> Websites { get; set; }
        /// <summary>
        /// If specified, the groups within active directory to show these links to.
        /// </summary>
        public string[] LimitToAdGroups { get; set; }

        public WebSiteCategory()
        {
            Websites = new List<WebSite>();
        }
    }
}
