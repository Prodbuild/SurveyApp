using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using EnrollmentWorkflow.Domain;
using EnrollmentWorkflow.Helpers;
using EnrollmentWorkflow.Models;
using EnrollmentWorkflow.WorkItemManager;
using GatewayEDI.Logging;
using Kendo.Mvc.UI;
using WorkItemEnums = EnrollmentWorkflow.Enums;

namespace EnrollmentWorkflow.Controllers
{
    public class ReportsController : Controller
    {
        private static readonly ILog Log = LogManager.GetLog(typeof(ReportsController));

        public ActionResult MissingGoLive(int missingGoLiveCount)
        {
            ViewBag.RequestedFor = "MissingGoLive";
            ViewBag.DataCount = missingGoLiveCount;

            return View("Sites");
        }

        public ActionResult MissingDaysToImplement(int missingDaysToImplementCount)
        {
            ViewBag.RequestedFor = "MissingDaysToImplement";
            ViewBag.DataCount = missingDaysToImplementCount;
            return View("Sites");
        }

        public ActionResult SitesInImplementation(int sitesInImplementationCount)
        {
            ViewBag.RequestedFor = "SitesInImplementation";
            ViewBag.DataCount = sitesInImplementationCount;
            return View("Sites");
        }

        public ActionResult LoadSites([DataSourceRequest] DataSourceRequest request, string requestedFor, int dataCount)
        {
            IEnumerable<WorkItemModel> pagedSiteModelList = null;
            var itemRequestedFor = requestedFor.Replace("-", " ");

            var workStatistics = new WorkItemStatistics();
            WorkItemEnums.WorkItemStatus? requestedStatus = null;

            string sortMember = string.Empty;
            string sortDirection = string.Empty;

            // Determining sort parameter and sort order
            if (request.Sorts != null && request.Sorts.Any())
            {
                sortMember = request.Sorts[0].Member;
                sortDirection = Convert.ToString(request.Sorts[0].SortDirection);
            }

            try
            {
                // == for charts category ==
                if (SelectListHelper.TryParseWorkItemStatus(itemRequestedFor, out requestedStatus))
                {
                    var siteModelList = workStatistics.GetAllWorkItemModels(isActiveRequired: true);
                    var filteredModelList = siteModelList.Where(x => x.WorkItemStatus == requestedStatus);

                    if (!string.IsNullOrEmpty(sortMember) && !string.IsNullOrEmpty(sortDirection))
                    {
                        PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(WorkItemModel)).Find(sortMember, false);

                        switch (sortDirection.ToUpper())
                        {
                            case "ASCENDING":
                                filteredModelList = filteredModelList
                                                                .OrderBy(x => prop.GetValue(x));
                                break;
                            case "DESCENDING":
                                filteredModelList = filteredModelList
                                                                .OrderByDescending(x => prop.GetValue(x));
                                break;
                            default:
                                filteredModelList = filteredModelList
                                                                .OrderBy(x => prop.GetValue(x));
                                break;
                        }
                    }

                    // When there will be no sorting parameter input, will paged data from original input list
                    pagedSiteModelList = filteredModelList
                                                    .Skip((request.Page - 1) * request.PageSize)
                                                    .Take(request.PageSize);

                    dataCount = filteredModelList.Count();
                }
                else
                {
                    var pageArguments = Tuple.Create(request.Page, request.PageSize);
                    var sortArguments = Tuple.Create(sortMember, sortDirection);
                    switch (itemRequestedFor)
                    {
                        case "MissingGoLive":
                            pagedSiteModelList = !string.IsNullOrEmpty(sortMember)
                                 ? workStatistics.GetPagedMissingGoLive(pageArguments, sortArguments)
                                 : workStatistics.GetPagedMissingGoLive(pageArguments);
                            break;
                        case "MissingDaysToImplement":
                            pagedSiteModelList = !string.IsNullOrEmpty(sortMember)
                                    ? workStatistics.GetPagedMissingDaysToImplement(pageArguments, sortArguments)
                                    : workStatistics.GetPagedMissingDaysToImplement(pageArguments);
                            break;
                        case "SitesInImplementation":

                            if (!string.IsNullOrEmpty(sortMember))
                            {
                                var pagedResults = workStatistics
                                                        .GetAllPagedActiveWorkItemModels(pageArguments, isActiveWorkItems: true, sortingArguments: sortArguments);
                                pagedSiteModelList = pagedResults.Item1;
                            }
                            else
                            {
                                pagedSiteModelList = workStatistics.GetPagedMissingDaysToImplement(pageArguments);
                            }

                            break;
                    }
                }

                return Json(new DataSourceResult
                {
                    Data = pagedSiteModelList,
                    Total = dataCount
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Log.Error("Unexpected error occurs while retrieving data.", ex);
                throw;
            }
        }

        public ActionResult Chart(string category)
        {
            ViewBag.RequestedFor = category.Replace(" ", "-");
            return View("Sites");
        }

        public ActionResult Settings()
        {
            var manager = new SettingsManager();

            var model = new SettingsModel
            {
                MissingGoLive = manager.MissingGoLiveEnrollment,
                NotTesting = manager.DaysAfterContractAndNotTesting,
                StillEnrolling = manager.DaysAfterContractButStillEnrolling
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult SaveSettings(SettingsModel model)
        {
            var manager = new SettingsManager();

            manager.DaysAfterContractAndNotTesting = model.NotTesting;
            manager.DaysAfterContractButStillEnrolling = model.StillEnrolling;
            manager.MissingGoLiveEnrollment = model.MissingGoLive;

            return new HttpStatusCodeResult(200);
        }

        public ActionResult LoadMissingGoLive()
        {
            var practices = new List<WorkItemModel>();
            return Json(practices);
        }

        public ActionResult LoadActiveWorkItems([DataSourceRequest] DataSourceRequest request, bool showActiveItems)
        {
            var sortMember = string.Empty;
            var sortDirection = string.Empty;

            // Determining sort parameter and sort order
            if (request.Sorts != null && request.Sorts.Any())
            {
                sortMember = request.Sorts[0].Member;
                sortDirection = Convert.ToString(request.Sorts[0].SortDirection);
            }

            // predicate filter for filtering data
            var workItemParameter = Expression.Parameter(typeof(WorkItem));
            List<Func<WorkItem, bool>> predicateFilters = null;


            if (request.Filters != null && request.Filters.Any())
            {
                foreach (var kendoFilter in request.Filters)
                {
                    var expression = kendoFilter.CreateFilterExpression(workItemParameter);

                    predicateFilters = predicateFilters ?? new List<Func<WorkItem, bool>>();
                    predicateFilters.Add(Expression.Lambda<Func<WorkItem, bool>>(expression, workItemParameter).Compile());
                }
            }

            var pagingArguments = Tuple.Create(request.Page, request.PageSize);
            var sortingArguments = Tuple.Create(sortMember, sortDirection);

            var workItemStats = new WorkItemStatistics();
            var pagedSiteModelBunchWithTotalCount = (!string.IsNullOrEmpty(sortMember) && !string.IsNullOrEmpty(sortDirection)) ?
                workItemStats.GetAllPagedActiveWorkItemModels(pagingArguments: pagingArguments, isActiveWorkItems: showActiveItems, predicateFilters: predicateFilters, sortingArguments: sortingArguments) :
                workItemStats.GetAllPagedActiveWorkItemModels(pagingArguments: pagingArguments, isActiveWorkItems: showActiveItems, predicateFilters: predicateFilters);

            return Json(new DataSourceResult
            {
                Data = pagedSiteModelBunchWithTotalCount.Item1,
                Total = pagedSiteModelBunchWithTotalCount.Item2
            });

        }
    }
}
