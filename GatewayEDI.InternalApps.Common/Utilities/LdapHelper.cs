using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace GatewayEDI.InternalApps.Common.Utilities
{
    public class LdapHelper
    {
        private readonly string _ldapUrl;

        public LdapHelper(string ldapUrl)
        {
            _ldapUrl = ldapUrl;
        }

        public bool VerifyLdapConnection()
        {
            using (DirectoryEntry entry = new DirectoryEntry(_ldapUrl))
            {
                using (var dirSearcher = new DirectorySearcher(entry))
                {
                    dirSearcher.Filter = string.Format("(CN={0})", "Domain Users");

                    var dirResult = dirSearcher.FindOne();
                    return dirResult != null;
                }
            }
        }

        public string GetUserEmail(string firstName, string lastName)
        {
            using (DirectoryEntry entry = new DirectoryEntry(_ldapUrl))
            {
                using (var dirSearcher = new DirectorySearcher(entry))
                {
                    dirSearcher.Filter = string.Format("(&(objectClass=user)(CN={0} {1}))", firstName, lastName);

                    var dirResult = dirSearcher.FindOne();
                    var imgBytes = dirResult.Properties["mail"][0];
                    return imgBytes.ToString();
                }
            }
        }

        public byte[] GetUserThumbnail(string firstName, string lastName)
        {
            using (DirectoryEntry entry = new DirectoryEntry(_ldapUrl))
            {
                using (var dirSearcher = new DirectorySearcher(entry))
                {
                    dirSearcher.Filter = string.Format("(&(objectClass=user)(CN={0} {1}))", firstName, lastName);

                    var dirResult = dirSearcher.FindOne();
                    byte[] imgBytes = (byte[]) dirResult.Properties["thumbnailphoto"][0];
                    return imgBytes;
                }
            }
        }

        /// <summary>
        /// Return byte array of user thumbnail or null if it does not exist.
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns>Byte array or null if not found</returns>
        public byte[] GetUserThumbnail(string userEmail)
        {
            using (DirectoryEntry entry = new DirectoryEntry(_ldapUrl))
            {
                using (var dirSearcher = new DirectorySearcher(entry))
                {
                    dirSearcher.Filter = string.Format("(&(objectClass=user)(mail={0}))", userEmail);

                    var dirResult = dirSearcher.FindAll();
                    var result = dirResult[0].Properties["thumbnailphoto"];
                    if (result.Count > 0)
                    {
                        return (byte[]) result[0];
                    }
                    return null;
                }
            }
        }

        /// <summary>
        /// Returns byte array of user thumbnail
        /// </summary>
        /// <param name="identity"></param>
        /// <returns>Byte array or null if not found</returns>
        public byte[] GetUserThumbnail(IIdentity identity)
        {
            NTAccount acct = new NTAccount(identity.Name);
            var sid = (SecurityIdentifier)acct.Translate(typeof(SecurityIdentifier));

            using (DirectoryEntry entry = new DirectoryEntry(_ldapUrl))
            {
                using (var dirSearcher = new DirectorySearcher(entry))
                {
                    dirSearcher.Filter = string.Format("(&(objectClass=user)(objectSid={0}))", sid.ToString());
                    var dirResult = dirSearcher.FindAll();

                    if (dirResult.Count == 0)
                        return null;

                    var result = dirResult[0].Properties["thumbnailphoto"];
                    if (result.Count > 0)
                    {
                        return (byte[]) dirResult[0].Properties["thumbnailphoto"][0];
                    }

                    return null;
                }
            }
        }

        public bool IsUserInAdGroup(IPrincipal principal, IEnumerable<string> groups)
        {
            using (var context = new PrincipalContext(ContextType.Domain))
            {
                var userPrincipal = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName,
                    principal.Identity.Name);

                if (userPrincipal == null)
                    return false;
                try
                {
                    return groups.Any(t => userPrincipal.IsMemberOf(context, IdentityType.SamAccountName, t));
                }
                catch (NoMatchingPrincipalException)
                {
                    return false;
                }
            }
        }
    }
}
