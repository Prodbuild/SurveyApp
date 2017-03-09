using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using EnrollmentWorkflow.Helpers.DataAnotationsExtensions;
using GatewayEDI.Logging;
using TPS.ServicesWeb.Common.Configuration;

namespace EnrollmentWorkflow
{


    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly ILog Log = LogManager.GetLog(typeof(MvcApplication));

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(ValidInteger), typeof(ValidIntegerValidator));

            this.LoadActiveDirectoryGroups();
        }

        protected void Application_Error(Object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();

            Log.Error(ex, "Handled exception.");
        }

        private void LoadActiveDirectoryGroups()
        {
            var cacheItemKeyForADGroup = Convert.ToString(ConfigurationManager.AppSettings["WorkListADGroupsCacheKeyName"]);
            var cacheRefreshTimeForAdGroup = Convert.ToInt32(ConfigurationManager.AppSettings["WorkListADGroupsCacheRefreshInSeconds"]);

            HttpRuntime.Cache.Insert(cacheItemKeyForADGroup, this.GetUserGroups(), null, DateTime.UtcNow.AddSeconds(cacheRefreshTimeForAdGroup),
                    Cache.NoSlidingExpiration, new CacheItemUpdateCallback(OnAdGroupCacheItemUpdated));
        }

        private void OnAdGroupCacheItemUpdated(string key, CacheItemUpdateReason reason, out object expensiveObject,
            out CacheDependency dependency, out DateTime absoluteExpiration, out TimeSpan slidingExpiration)
        {
            var cacheRefresh = Convert.ToInt32(ConfigurationManager.AppSettings["WorkListADGroupsCacheRefreshInSeconds"]);

            expensiveObject = this.GetUserGroups();
            dependency = null;
            absoluteExpiration = DateTime.UtcNow.AddSeconds(cacheRefresh);
            slidingExpiration = Cache.NoSlidingExpiration;
        }

        private Dictionary<string, Dictionary<string, string>> GetUserGroups()
        {
            var groupUserMembersCollection = new Dictionary<string, Dictionary<string, string>>();

            try
            {
                string groups = TpsServicesWebConfig.GetEnvSetting("WorkListADGroups");
                IList<string> groupNames = groups.Split(',');

                var context = new PrincipalContext(ContextType.Domain);

                foreach (var groupName in groupNames)
                {
                    try
                    {
                        var group = GroupPrincipal.FindByIdentity(context, groupName);
                        Dictionary<string, string> userMemberList = new Dictionary<string, string>();

                        foreach (var principal in group.GetMembers())
                        {
                            var userPrincipal = principal as UserPrincipal;

                            if (userPrincipal != null)
                            { userMemberList.Add(userPrincipal.SamAccountName, userPrincipal.DisplayName); }

                        }

                        groupUserMembersCollection.Add(groupName, userMemberList);

                    }
                    catch (Exception ex)
                    {

                        Log.Error(ex, "Couldn't get group members {0}.", string.Join(", ", groupNames));
                        continue;
                    }
                }
            }
            catch (Exception ex)
            { Log.Error(ex); }

            return groupUserMembersCollection;
        }
    }
}