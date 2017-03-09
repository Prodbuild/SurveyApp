using System;
using System.Collections.Generic;
using System.Linq;
using EnrollmentWorkflow.WorkItemManager;

namespace EnrollmentWorkflow.Helpers
{
    public class WorkItemStatusMapper
    {
        public static Enums.WorkItemStatus Map(WorkItemManager.WorkItemStatus status)
        {
            if (status == WorkItemManager.WorkItemStatus.HoldForFutureGoLiveDate)
                return Enums.WorkItemStatus.HoldForFutureGoLiveDate;

            if (status == WorkItemManager.WorkItemStatus.PendingInitialLogin)
                return Enums.WorkItemStatus.PendingInitialLogin;

            if (status == WorkItemManager.WorkItemStatus.PendingPaperwork)
                return Enums.WorkItemStatus.PendingPaperwork;

            if (status == WorkItemManager.WorkItemStatus.PendingSubmission)
                return Enums.WorkItemStatus.PendingSubmission;

            if (status == WorkItemManager.WorkItemStatus.PendingTPSReview)
                return Enums.WorkItemStatus.PendingTPSReview;

            if (status == WorkItemManager.WorkItemStatus.ProcessingEnrollment)
                return Enums.WorkItemStatus.ProcessingEnrollment;

            if (status == WorkItemManager.WorkItemStatus.Testing)
                return Enums.WorkItemStatus.Testing;

            if (status == WorkItemStatus.WaitingClientTestFile)
                return Enums.WorkItemStatus.WaitingClientTestFile;

            if (status == WorkItemStatus.WaitingVendorTestFile)
                return Enums.WorkItemStatus.WaitingVendorTestFile;

            if (status == WorkItemStatus.PendingSubsequentFile)
                return Enums.WorkItemStatus.PendingSubsequentFile;

            if (status == WorkItemStatus.Live)
                return Enums.WorkItemStatus.Live;

            // This is a catch all.
            IEnumerable<Enums.WorkItemStatus> list = Enum.GetValues(typeof(Enums.WorkItemStatus)).Cast<Enums.WorkItemStatus>();

            return list.First(x => x.ToString().Equals(status.ToString(), StringComparison.OrdinalIgnoreCase));
        }
    }
}