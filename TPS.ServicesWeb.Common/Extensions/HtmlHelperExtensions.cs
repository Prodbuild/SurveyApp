using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.WebPages.Scope;
using TPS.ServicesWeb.Common.BusinessObjects;
using TPS.ServicesWeb.Common.MvcHelpers;
using TPS.ServicesWeb.Common.Utilities;

namespace TPS.ServicesWeb.Common.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static TpsSvcWeb TpsSvcWeb(this HtmlHelper helper)
        {
            return new TpsSvcWeb(helper);
        }
    }
}
