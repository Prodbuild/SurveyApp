using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EnrollmentWorkflow.Helpers;

namespace EnrollmentWorkflow.Enums
{
    public enum WorkItemStatus
    {
        [EnumStringValue("Pending Initial Login")]
        PendingInitialLogin,

        [EnumStringValue("Pending Submission")]
        PendingSubmission,

        [EnumStringValue("Pending TPS Review")]
        PendingTPSReview,

        [EnumStringValue("Hold For Future Go Live Date")]
        HoldForFutureGoLiveDate,

        [EnumStringValue("Processing Enrollment")]
        ProcessingEnrollment,

        [EnumStringValue("Pending Paperwork")]
        PendingPaperwork,

        [EnumStringValue("Waiting Client Test File")]
        WaitingClientTestFile,

        [EnumStringValue("Waiting Vendor Test File")]
        WaitingVendorTestFile,

        [EnumStringValue("Testing")]
        Testing,

        [EnumStringValue("Pending Subsequent File")]
        PendingSubsequentFile,

        [EnumStringValue("Live")]
        Live,

        [EnumStringValue("Pending Contract")]
        PendingContract        
    }
}