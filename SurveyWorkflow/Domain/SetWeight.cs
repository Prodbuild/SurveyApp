using System;
using System.Collections.Generic;
using EnrollmentWorkflow.Enums;
using EnrollmentWorkflow.EventService;
using EnrollmentWorkflow.Helpers;
using EnrollmentWorkflow.Models;

namespace EnrollmentWorkflow.Domain
{
    public class SetWeight
    {
        public static void Set(List<WorkItemModel> workItems)
        {
            foreach (var workItem in workItems)
            {
                int weight = 0;

                // [LOW] Client logged in to Portal, but has not submitted information (4 days)
                if (workItem.WorkItemStatus == WorkItemStatus.PendingSubmission)
                {
                    DateTime? firstLogonTime = WcfClient<EventServiceClient>
                        .Instantiate(() => new EventServiceClient())
                        .Return(client => client.GetLastOccurrence(workItem.SiteId, EventCode.LoggedInFirstTime));

                    if (firstLogonTime != null && (DateTime.Now - firstLogonTime.Value).TotalDays >= 4)
                        weight += 1;
                }

                // [HIGH] Client submits Practice when go live within 7 days
                DateTime? lastSubmission = WcfClient<EventServiceClient>
                    .Instantiate(() => new EventServiceClient())
                    .Return(client => client.GetLastOccurrence(workItem.SiteId, EventCode.SubmitEnrollment));

                if (lastSubmission != null && workItem.GoLiveDate != null)
                {
                    double days = (workItem.GoLiveDate.Value - lastSubmission.Value).TotalDays;

                    if (days <= 7 && days >= 0)
                        weight += 3;
                }

                // [HIGH] Client info Pending TPS review 
                if (workItem.WorkItemStatus == WorkItemStatus.PendingTPSReview)
                    weight += 3;

                // [HIGH] Signed paperwork not received back from client (5 days)
                if (workItem.WorkItemStatus == WorkItemStatus.PendingPaperwork && !workItem.PaperworkReceived.HasValue)
                {
                    DateTime? lastStatusChange = WcfClient<EventServiceClient>
                        .Instantiate(() => new EventServiceClient())
                        .Return(client => client.GetLastOccurrence(workItem.SiteId, EventCode.WorkItemStatusChange));

                    if (lastStatusChange != null)
                    {
                        double days = (DateTime.Now - lastStatusChange.Value).TotalDays;

                        if (days >= 5)
                            weight += 3;
                    }
                }

                workItem.Weight = weight;
            }
        }
    }
}