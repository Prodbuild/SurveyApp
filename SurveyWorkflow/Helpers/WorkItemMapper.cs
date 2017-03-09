using EnrollmentWorkflow.Models;
using EnrollmentWorkflow.WorkItemManager;
using EnrollmentWorkflow.EventService;
using EnrollmentWorkflow.PracticeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using EnrollmentWorkflow.Domain;

namespace EnrollmentWorkflow.Helpers
{
    public class WorkItemMapper
    {
        public static WorkItemModel Map(WorkItem serviceWorkItem, bool isWelComeEmailSentTobeCalculated = false)
        {
            var eventService = new EventServiceClient();

            var workItem = new WorkItemModel
            {
                ClientSubmissionDate = serviceWorkItem.ClientSubmissionDate,
                ContractDate = serviceWorkItem.ContractDate,
                Created = serviceWorkItem.Created,
                DaysToImplement = serviceWorkItem.ContractDate != null ? Convert.ToInt32(WorkItemStatistics.CountBusinessDays(serviceWorkItem.ContractDate.Value, DateTime.Now)) : 0,
                DocCount = serviceWorkItem.DocCount,
                ecwGroup = serviceWorkItem.EcwGroup,
                ecwProjectManager = serviceWorkItem.EcwProjectManager,
                EnrollmentRep = serviceWorkItem.EnrollmentRep,
                EnrollmentSentToThirdParty = serviceWorkItem.EnrollmentSentDate,
                GoLiveChanges = serviceWorkItem.GoLiveChanges,
                GoLiveDate = serviceWorkItem.GoLiveDate,
                Id = serviceWorkItem.WorkItemId,
                InstallDate = serviceWorkItem.InstallDate,
                InstallType = serviceWorkItem.InstallType,
                IntroDate = serviceWorkItem.IntroDate,
                KickOffCallDate = serviceWorkItem.KickOffCallDate,
                LastContacted = serviceWorkItem.LastContactedDate,
                Modified = serviceWorkItem.Modified,
                ModifiedBy = serviceWorkItem.ModifiedBy,
                MovedOutOfImplementation = serviceWorkItem.MovedOutOfImplementation,
                Notes = serviceWorkItem.Notes,
                OfficeName = serviceWorkItem.OfficeName,
                PaperworkReceived = serviceWorkItem.PaperworkReceivedDate,
                PaperworkSentToPayer = serviceWorkItem.PaperworkSentDate,
                ProductionDate = serviceWorkItem.ProductionDate,
                ProvidersSold = serviceWorkItem.ProvidersSold,
                ReinstateDate = serviceWorkItem.ReinstatedDate,
                TAFReceivedDate = serviceWorkItem.TAFReceivedDate,
                SiteId = serviceWorkItem.SiteId,
                SiteAnalysisAttempts = serviceWorkItem.SiteAnalysisAttempts,
                SiteAnalysisDue = serviceWorkItem.SiteAnalysisDue,
                Status = SelectListHelper.GetEnumStringValue(serviceWorkItem.WorkItemStatus),
                WorkItemStatus = WorkItemStatusMapper.Map(serviceWorkItem.WorkItemStatus),
                TestingDate1 = serviceWorkItem.TestingDate1,
                TestingRep = serviceWorkItem.TestingRep,
                Vendor = serviceWorkItem.Vendor,
                WelcomeEmailLastSent = isWelComeEmailSentTobeCalculated
                                                ? eventService.GetLastOccurrence(serviceWorkItem.SiteId, EventCode.WelcomeEmailSent).ToString()
                                                : string.Empty,
                IsActive = serviceWorkItem.IsActive
            };

            return workItem;
        }
    }
}