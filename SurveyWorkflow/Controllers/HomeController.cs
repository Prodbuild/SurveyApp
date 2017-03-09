using EnrollmentWorkflow.Domain;
using EnrollmentWorkflow.Helpers;
using EnrollmentWorkflow.Models;
using EnrollmentWorkflow.WorkItemManager;
using GatewayEDI.InternalApps.Common.Utilities;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using System.Web.SessionState;
using TPS.ServicesWeb.Common.BaseClasses;
using TPS.ServicesWeb.Common.Configuration;
using WorkItemStatus = EnrollmentWorkflow.Enums.WorkItemStatus;

namespace EnrollmentWorkflow.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : TpsSvcsWebHomeController
    {
        public IList<WorkItemModel> WorkItems = new List<WorkItemModel>();
        private readonly WorkItemServiceClient workItemManager = new WorkItemServiceClient();
        private readonly WorkItemStatistics workItemStatistics = new WorkItemStatistics();


        public ActionResult Index()
        {
            var homeModel = CalculateStatisticalData();
            return View(homeModel);
        }


        private HomeModel CalculateStatisticalData()
        {
            var categories = new List<WorkItemCategoryModel>();
            var catCount = 1;

            foreach (var value in SelectListHelper.EnumToList<WorkItemStatus>())
            {
                var category = new WorkItemCategoryModel();
                category.Category = SelectListHelper.GetEnumStringValue(value);
                category.Id = catCount++;
                categories.Add(category);
            }

            var domainUsers = new DomainUsers();
            string user = domainUsers.GetCurrentUser(User).ToLower();
            ViewBag.User = user;
            ViewBag.Email = GetRepEmail(user);
            ViewBag.IsAdmin = IsAdmin();
            LoadGroupMembersInViewBag();

            var workItems = workItemStatistics.GetAllWorkItems(true);
            var workItemModels = workItemStatistics.GetAllWorkItemModels(workItems, isActiveRequired: true);

            var averageDaysToImplement = workItemModels.Sum(i => workItemStatistics.CalculateAverageDaysToImplement(i));
            averageDaysToImplement = (workItemModels != null && workItemModels.Any()) ? averageDaysToImplement / workItemModels.Count() : 0;

            var missingDaysToImplement = workItemStatistics.GetMissingDaysToImplement(workItems).Count();
            var missingGoLive = workItemStatistics.GetMissingGoLive(workItems).Count();

            return new HomeModel
            {
                AverageDaysToImplement = averageDaysToImplement,
                MissingGoLive = missingGoLive,
                MissingDaysToImplement = missingDaysToImplement,
                SitesInImplementation = (workItemModels != null && workItemModels.Any()) ? workItemModels.Count() : 0,
                WorkItemCategories = categories
            };
        }


        public ActionResult LoadWorkItems([DataSourceRequest] DataSourceRequest request, string selectedUser, string category, bool prioritized = false)
        {
            List<WorkItemModel> filteredWorkItems = null;
            DataSourceResult result = null;

            if (selectedUser != null)
            {
                var serviceWorkItems = workItemStatistics.GetAllWorkItems(true);

                var userWorkItems = serviceWorkItems.Where(items => items.EnrollmentRep == selectedUser);

                if (userWorkItems != null && userWorkItems.Any())
                {
                    var workItemModels = userWorkItems
                                                    .Select(w => WorkItemMapper.Map(w))
                                                    .ToList();

                    if (!String.IsNullOrEmpty(category))
                    {
                        filteredWorkItems = workItemModels
                                                        .Where(x => x.Status == SelectListHelper.GetEnumFromString(category).ToString())
                                                        .ToList();
                    }
                    else
                        filteredWorkItems = workItemModels;
                }
            }

            if (filteredWorkItems != null && filteredWorkItems.Any())
            {
                filteredWorkItems.Sort(new WorkItemComparer());

                if (prioritized)
                {
                    SetWeight.Set(filteredWorkItems);

                    result = filteredWorkItems
                                    .OrderByDescending(x => x.Weight)
                                    .ThenByDescending(x => x.GoLiveDate)
                                    .ThenBy(x => x.SiteId)
                                    .ToDataSourceResult(request);
                }
                else
                {
                    result = filteredWorkItems
                                    .OrderByDescending(x => x.GoLiveDate)
                                    .ThenBy(x => x.SiteId)
                                    .ToDataSourceResult(request);
                }
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult LoadWorkItemsGridContainer(List<WorkItemCategoryModel> workItemCategories, string tabName)
        {
            ActionResult returnResult = null;

            LoadGroupMembersInViewBag();

            var domainUsers = new DomainUsers();
            string user = domainUsers.GetCurrentUser(User).ToLower();
            ViewBag.User = user;

            ViewBag.IsAdmin = IsAdmin();

            switch (tabName.ToLower())
            {
                case "activeworkitemslist":
                    returnResult = PartialView("WorkItemManager");
                    break;
                case "workqueue":
                    returnResult = PartialView("WorkItems", workItemCategories);
                    break;
                case "worklist":
                    returnResult = PartialView("WorkList");
                    break;
                case "dashboard":
                    var homeModel = CalculateStatisticalData();
                    returnResult = PartialView("Dashboard", homeModel);
                    break;
            }
            return returnResult;
        }

        public override ActionResult Monitor()
        {
            return Content("OK");
        }

        private void LoadGroupMembersInViewBag()
        {
            IDictionary<string, string> groupMembers = new DomainUsers().GetGroupMembers();
            var selectList = new List<SelectListItem>();

            selectList.Add(new SelectListItem
            {
                Text = "Unassigned",
                Value = String.Empty
            });

            foreach (var groupMember in groupMembers)
            {
                selectList.Add(new SelectListItem
                {
                    Text = groupMember.Value,
                    Value = groupMember.Key.ToLower()
                });
            }

            ViewBag.GroupMembers = selectList;
        }

        private bool IsAdmin()
        {
            var ldapHelper = new LdapHelper(ConfigurationManager.AppSettings["LdapUrl"]);
            IList<string> group = new List<string>();
            string groups = TpsServicesWebConfig.GetEnvSetting("AdminADGroups");
            group = groups.Split(',');

            return ldapHelper.IsUserInAdGroup(User, group);
        }


        private string GetRepEmail(string principalUsername)
        {
            string email = "";
            if (!string.IsNullOrEmpty(principalUsername))
            {
                principalUsername = principalUsername.ToLower();
                email = workItemManager.GetRepEmail(principalUsername);
            }

            return email;

        }

        [HttpPost]
        public ActionResult UpdateRepEmail(string principalUsername, string email)
        {
            if (!string.IsNullOrEmpty(principalUsername))
            {
                principalUsername = principalUsername.ToLower();
                workItemManager.UpdateRepEmail(principalUsername, email);
            }

            return RedirectToAction("Index");
        }

        public JsonResult SearchForSite()
        {
            var workItems = workItemStatistics.GetAllWorkItems(true)
                                                                .Select(workItem => new
                                                                {
                                                                    Id = workItem.WorkItemId,
                                                                    SiteId = workItem.SiteId,
                                                                    EnrollmentRep = workItem.EnrollmentRep
                                                                });

            return Json(workItems, JsonRequestBehavior.AllowGet);
        }

        private class WorkItemComparer : IComparer<WorkItemModel>
        {
            int IComparer<WorkItemModel>.Compare(WorkItemModel a, WorkItemModel b)
            {
                if (String.Compare(a.EnrollmentRep, b.EnrollmentRep, true) < 0)
                    return 1;
                if (String.Compare(a.EnrollmentRep, b.EnrollmentRep, true) > 0)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
