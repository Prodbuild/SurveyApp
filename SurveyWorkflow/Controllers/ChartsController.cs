using EnrollmentWorkflow.Domain;
using EnrollmentWorkflow.Helpers;
using EnrollmentWorkflow.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TPS.ServicesWeb.Common.Configuration;
using WorkItemStatus = EnrollmentWorkflow.Enums.WorkItemStatus;

namespace EnrollmentWorkflow.Controllers
{
    public class ChartsController : Controller
    {
        [HttpPost]
        public ActionResult LoadChartData()
        {
            var statusModelCollection = new Dictionary<WorkItemStatus, SitesInImplementationModel>();

            var stats = new WorkItemStatistics();
            IEnumerable<WorkItemModel> workItems = stats.GetAllWorkItemModels(isActiveRequired: true);
            IEnumerable<WorkItemStatus> statuses = SelectListHelper.EnumToList<WorkItemStatus>();

            foreach (var status in statuses)
            {
                if (!statusModelCollection.ContainsKey(status))
                    statusModelCollection.Add(status, new SitesInImplementationModel());

                statusModelCollection[status].Status = SelectListHelper.GetEnumStringValue(status);

                statusModelCollection[status].Count = workItems
                    .Count(x => x.Status.Equals(status.ToString(), StringComparison.OrdinalIgnoreCase));
            }

            return Json(statusModelCollection.Select(x => x.Value));
        }


        public ActionResult LoadUserReport([DataSourceRequest] DataSourceRequest request)
        {
            IDictionary<string, string> users = new DomainUsers().GetGroupMembers();

            var workItemModelDictionary = new Dictionary<string, WorkItemReportModel>(StringComparer.OrdinalIgnoreCase);
            var stats = new WorkItemStatistics();
            IEnumerable<WorkItemModel> workItemModels = stats.GetAllWorkItemModels(isActiveRequired: true);

            foreach (KeyValuePair<string, string> user in users)
            {
                WorkItemReportModel workItemReportModel;

                if (!workItemModelDictionary.TryGetValue(user.Key, out workItemReportModel))
                {
                    workItemReportModel = new WorkItemReportModel
                    {
                        RepSamName = user.Key,
                        RepDisplayName = user.Value
                    };

                    workItemModelDictionary.Add(user.Key, workItemReportModel);
                }

                var assignedWorkItems = workItemModels
                                                    .Where(x => x.EnrollmentRep.Equals(user.Key, StringComparison.OrdinalIgnoreCase));

                if (assignedWorkItems.Any())
                {
                    foreach (var workItem in assignedWorkItems)
                    {
                        workItemReportModel.ADI += stats.CalculateAverageDaysToImplement(workItem);
                    }

                    var assignedWorkItemCount = assignedWorkItems.Count();

                    workItemReportModel.ADI = workItemReportModel.ADI / assignedWorkItemCount;
                    workItemReportModel.OpenWorkItems = assignedWorkItemCount;
                }
            }

            var result = workItemModelDictionary
              .Select(x => x.Value)
              .OrderBy(x => x.RepDisplayName)
              .ToDataSourceResult(request);

            return Json(result);
        }

    }
}
