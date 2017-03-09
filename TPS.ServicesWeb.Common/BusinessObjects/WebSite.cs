using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS.ServicesWeb.Common.BusinessObjects
{
    public class WebSite
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        public string ToLink()
        {
            return string.Format("<a href=\"{0}\" title=\"{1}\">{2}</a>", Url, Description, Name);
        }
    }
}
