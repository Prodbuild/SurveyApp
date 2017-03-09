using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GatewayEDI.InternalApps.Common.Utilities;
using GatewayEDI.Logging;
using TPS.ServicesWeb.Common.BusinessObjects;

namespace TPS.ServicesWeb.Common.Utilities
{
    public class TopLevelNavReader
    {
        private static readonly ILog _log = LogManager.GetLog(typeof(TopLevelNavReader));
        private readonly string _xmlUri;

        public TopLevelNavReader(string xmlUri)
        {
            _xmlUri = xmlUri;
        }

        public List<WebSiteCategory> Read(LdapHelper ldapHelper, IPrincipal userPrincipal)
        {
            var categories = Read();
            categories.RemoveAll(t => t.LimitToAdGroups != null
                                      && !ldapHelper.IsUserInAdGroup(userPrincipal, t.LimitToAdGroups));

            return categories;
        }

        public List<WebSiteCategory> Read()
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(_xmlUri.ToString());
                var websiteCategories =
                    from category in xmlDoc.Descendants("category")
                    orderby category.Attribute("name").Value
                    select category;
                var categories = new List<WebSiteCategory>();
                foreach (var categoryXml in websiteCategories)
                {
                    var category = new WebSiteCategory();
                    category.Name = categoryXml.Attribute("name").Value;
                    category.Websites = new List<WebSite>(from webSite in categoryXml.Descendants("website")
                                                              select new WebSite()
                                                              {
                                                                  Name = webSite.Attribute("name").Value,
                                                                  Url = webSite.Descendants("url").First().Value,
                                                                  Description = webSite.Descendants("description").First().Value
                                                              });
                    var adGroups = categoryXml.Attribute("adgroups");
                    if (adGroups != null)
                    {
                        category.LimitToAdGroups = adGroups.Value.Split(new [] {','},
                            StringSplitOptions.RemoveEmptyEntries);
                    }
                    categories.Add(category);
                }
                return categories;
            }
            catch (Exception ex)
            {
                _log.Error(ex, "Unable to read the website links");
                throw;
            }
        }
    }
}
