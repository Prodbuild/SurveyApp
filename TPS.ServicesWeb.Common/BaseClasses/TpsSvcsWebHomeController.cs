using System.Configuration;
using System.Net.Mime;
using System.Reflection;
using System.Web.Mvc;
using GatewayEDI.Logging;
using TPS.ServicesWeb.Common.Configuration;

namespace TPS.ServicesWeb.Common.BaseClasses
{
    public abstract class TpsSvcsWebHomeController : Controller
    {
        protected ILog log = LogManager.GetLog(typeof (TpsSvcsWebHomeController));

        public TpsSvcsWebHomeController()
        {
            
        }

        /// <summary>
        /// Override this method to perform a monitoring check for system health.
        /// If successful, the page should return a Content("OK") message.  Otherwise,
        /// please provide debug information.
        /// </summary>
        /// <returns></returns>
        public abstract ActionResult Monitor();

        public virtual ActionResult Debug()
        {
            var viewModel = new BaseDebugViewModel
            {
                AppPoolIdentity = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                EnvironmentIdentifier = TpsServicesWebConfig.EnvironmentIdentifier,
                SitePath = Server.MapPath("~"),
                MainAssembly = Assembly.GetExecutingAssembly().GetName()
            };
            return View(viewModel);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
                log.Error(filterContext.Exception);
            base.OnException(filterContext);
        }
    }
}
