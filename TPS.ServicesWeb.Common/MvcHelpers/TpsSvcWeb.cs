using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using GatewayEDI.InternalApps.Common.Utilities;
using TPS.ServicesWeb.Common.Utilities;

namespace TPS.ServicesWeb.Common.MvcHelpers
{
    public class TpsSvcWeb
    {
        private HtmlHelper _helper;

        public TpsSvcWeb(HtmlHelper helper)
        {
            _helper = helper;
        }

        public MvcHtmlString TopLevelNavigation()
        {
            return TopLevelNavigation(
                navXmlUrl: ConfigurationManager.AppSettings["TopLevelNavUrl"],
                ldapUrl: ConfigurationManager.AppSettings["LdapUrl"],
                userPrincipal: _helper.ViewContext.HttpContext.User
                );
        }

        public MvcHtmlString TopLevelNavigation(string navXmlUrl, string ldapUrl, IPrincipal userPrincipal)
        {
            var ldapHelper = new LdapHelper(ldapUrl);
            var nav = new TopLevelNavReader(navXmlUrl);
            var categories = nav.Read();
            var groupsSessionKey = "navCategories";

            StringBuilder sb = new StringBuilder();
            Dictionary<string, bool> accessCategories = (_helper.ViewContext.HttpContext.Session == null ||
                                            _helper.ViewContext.HttpContext.Session[groupsSessionKey] == null)
                ? new Dictionary<string, bool>()
                : (Dictionary<string, bool>)_helper.ViewContext.HttpContext.Session[groupsSessionKey];
            
            sb.Append("<li class=\"dropdown\">");
            sb.Append(
                "<a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\" role=\"button\" aria-expanded=\"false\">Directory <span class=\"caret\"></span></a>");
            sb.Append("<ul class=\"dropdown-menu\" role=\"menu\">");
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].LimitToAdGroups != null)
                {
                    // check the dictionary to see if it should be displayed
                    if (accessCategories.ContainsKey(categories[i].Name) && !accessCategories[categories[i].Name])
                        continue;

                    // check to see if the category should be displayed
                    if (!accessCategories.ContainsKey(categories[i].Name))
                    {
                        accessCategories[categories[i].Name] = ldapHelper.IsUserInAdGroup(userPrincipal,
                            categories[i].LimitToAdGroups);

                        // if it should not be displayed, continue on to next category
                        if (!accessCategories[categories[i].Name])
                            continue;
                    }
                }

                // note that submenus have been depricated in bootstrap v3.
                sb.AppendFormat(
                    "<li class=\"dropdown-header\"><label>{0}</label>",
                    categories[i].Name);
                sb.AppendFormat("<ul class=\"nav\" role=\"menu\">");

                foreach (var website in categories[i].Websites)
                {
                    sb.AppendFormat("<li>{0}</li>", website.ToLink());
                }
                sb.Append("</ul></li>");
                if (i < categories.Count - 1)
                    sb.Append("<li class=\"divider\"></li>");
            }
            sb.Append("</ul></li>");
            if (_helper.ViewContext.HttpContext.Session != null)
                _helper.ViewContext.HttpContext.Session[groupsSessionKey] = accessCategories;

            return MvcHtmlString.Create(sb.ToString());
        }

        public IDisposable BeginPanel(string headerText, string id = null)
        {
            _helper.ViewContext.Writer.Write(string.Format("<div class=\"panel panel-default\" id=\"{0}\">" +
                                                          "<div class=\"panel-heading\">{1}</div>" +
                                                          "<div class=\"panel-body\">", id, headerText));
            return new BootstrapPanel(_helper);
        }

        class BootstrapPanel : IDisposable
        {
            private readonly HtmlHelper _htmlHelper;

            public BootstrapPanel(HtmlHelper helper)
            {
                _htmlHelper = helper;
            }

            public void Dispose()
            {
                _htmlHelper.ViewContext.Writer.Write("</div></div>");
            }
        }

        public IDisposable BeginHeader(string headerText)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<nav class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">");
            sb.AppendLine("    <div class=\"row col-xs-12\">");
            sb.AppendLine("    <div class=\"navbar-header\">");
            sb.AppendLine("      <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">");
            sb.AppendLine("        <span class=\"sr-only\">Toggle navigation</span>");
            sb.AppendLine("        <span class=\"icon-bar\"></span>");
            sb.AppendLine("        <span class=\"icon-bar\"></span>");
            sb.AppendLine("        <span class=\"icon-bar\"></span>");
            sb.AppendLine("      </button>");
            sb.AppendLine("      <a class=\"navbar-brand\" rel=\"home\" href=\"/\" title=\"TPS Services Web - Directory\">");
            sb.AppendLine("        <img alt=\"TPS Internal Applications\" src=\"/Images/NewTPSLogo.png\" class=\"navbar-image\" />");
            sb.AppendLine("      </a>");
            sb.AppendLine("      <a class=\"navbar-brand\" href=\"" + _helper.ViewContext.RequestContext.HttpContext.Request.ApplicationPath + "\">" + headerText + "</a>");
            sb.AppendLine("    </div>"); // end navbar-header
            sb.AppendLine("    <div class=\"collapse navbar-collapse\">");
            sb.AppendLine("      <ul class=\"nav navbar-nav navbar-right\">");
            sb.Append(TopLevelNavigation());
            sb.AppendLine("      </ul>");
            sb.AppendLine("    </div>"); // end navbar-collapse
            sb.AppendLine("    </div>"); // end navbar row
            sb.AppendLine("    <div class=\"row col-xs-12\">");
            sb.AppendLine("      <div class=\"navbar-second-row collapse navbar-collapse\">");
            sb.AppendLine("      <ul class=\"nav navbar-nav\">");
            
            _helper.ViewContext.Writer.Write(sb.ToString());
            var topLevelNav = TopLevelNavigation();

            return new TpsWebHeader(_helper);
        }

        class TpsWebHeader : IDisposable
        {
            private readonly HtmlHelper _htmlHelper;

            public TpsWebHeader(HtmlHelper helper)
            {
                _htmlHelper = helper;
            }

            public void Dispose()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("</ul></div>");
                sb.AppendLine("</div>"); // end row
                sb.AppendLine("</nav>"); // end nav

                _htmlHelper.ViewContext.Writer.Write(sb.ToString());
            }
        }
    }
}
