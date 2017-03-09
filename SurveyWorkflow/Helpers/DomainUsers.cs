using System;
using System.Collections.Generic;
using System.Linq;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;
using GatewayEDI.Logging;
using System.Configuration;
using System.Web;
using TPS.ServicesWeb.Common.Configuration;

namespace EnrollmentWorkflow.Helpers
{
    public class DomainUsers
    {
        private static readonly ILog Log = LogManager.GetLog(typeof(DomainUsers));

        public string GetCurrentUser(IPrincipal principal)
        {
            try
            {
                var context = new PrincipalContext(ContextType.Domain);
                var userPrincipal = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName,
                    principal.Identity.Name);

                if (userPrincipal == null)
                    return String.Empty;

                return userPrincipal.SamAccountName;
            }
            catch (Exception e)
            {
                Log.Error(e, "Couldn't get current user {0}.", principal.Identity.Name);
                return String.Empty;
            }
        }

        public IDictionary<string, string> GetGroupMembers(string groupName)
        {
            Dictionary<string, string> groupMembers = new Dictionary<string, string>();

            var cacheItemKeyForADGroup = Convert.ToString(ConfigurationManager.AppSettings["WorkListADGroupsCacheKeyName"]);
            var groupMemberCollection = HttpRuntime.Cache[cacheItemKeyForADGroup] as Dictionary<string, Dictionary<string, string>>;

            try
            {
                if (groupMemberCollection == null)
                {
                    var context = new PrincipalContext(ContextType.Domain);
                    var group = GroupPrincipal.FindByIdentity(context, groupName);

                    foreach (var principal in group.GetMembers())
                    {
                        var userPrincipal = principal as UserPrincipal;

                        if (userPrincipal != null)
                        {
                            if (!groupMembers.ContainsKey(userPrincipal.SamAccountName))
                            { groupMembers.Add(userPrincipal.SamAccountName, userPrincipal.DisplayName); }
                        }
                    }
                }

                else
                {
                    groupMemberCollection.TryGetValue(groupName, out groupMembers);
                }
            }
            catch (Exception e)
            {
                Log.Error(e, "Couldn't get group members {0}.", groupName);
            }

            return groupMembers ?? new Dictionary<string, string>();
        }

        public IDictionary<string, string> GetGroupMembers()
        {

            IDictionary<string, string> userCollection = null;

            try
            {
                var cacheItemKeyForADGroup = Convert.ToString(ConfigurationManager.AppSettings["WorkListADGroupsCacheKeyName"]);
                var groupMemberCollection = HttpRuntime.Cache[cacheItemKeyForADGroup] as Dictionary<string, Dictionary<string, string>>;

                if (groupMemberCollection == null)
                {
                    groupMemberCollection = new Dictionary<string, Dictionary<string, string>>();

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

                            if (!groupMemberCollection.ContainsKey(groupName))
                            { groupMemberCollection.Add(groupName, userMemberList); }
                        }

                        catch (Exception e)
                        {
                            Log.Error(e, "Couldn't get group members {0}.", string.Join(", ", groupName));
                            continue;
                        }
                    }
                }

                userCollection = groupMemberCollection.Values.SelectMany(x => x).Distinct().ToDictionary(x => x.Key, y => y.Value);
            }
            catch (Exception e)
            {
                Log.Error(e);
            }

            return userCollection ?? new Dictionary<string, string>();

        }
    }
}