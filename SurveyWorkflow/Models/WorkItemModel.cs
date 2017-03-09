using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EnrollmentWorkflow.Enums;

namespace EnrollmentWorkflow.Models
{
    public class WorkItemModel
    {
        public WorkItemModel()
        {
            Weight = -1;
        }

        public int Id { get; set; }

        [DisplayName("Site Id")]
        public String SiteId { get; set; }

        [DisplayName("Office Name")]
        public String OfficeName { get; set; }

        [DisplayName("eCW")]
        public bool IsEcw { get; set; }

        [DisplayName("Project Manager")]
        public String ecwProjectManager { get; set; }

        [DisplayName("eCW Group")]
        public String ecwGroup { get; set; }

        [DisplayName("Cerner")]
        public bool IsCerner { get; set; }

        [DisplayName("Vendor")]
        public String Vendor { get; set; }

        [DisplayName("Contract Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ContractDate { get; set; }

        [DisplayName("Last Contacted")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? LastContacted { get; set; }

        [DisplayName("Providers Sold")]
        public int ProvidersSold { get; set; }

        [DisplayName("Doc Count")]
        public int DocCount { get; set; }

        [DisplayName("Site Analysis Attempts")]
        public int SiteAnalysisAttempts { get; set; }

        [DisplayName("Site Analysis Due")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? SiteAnalysisDue { get; set; }

        [DisplayName("Moved Out Of Implementation")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? MovedOutOfImplementation { get; set; }

        [DisplayName("Target Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? TargetDate { get; set; }

        [DisplayName("Go Live Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? GoLiveDate { get; set; }

        [DisplayName("Go Live Changes")]
        public int GoLiveChanges { get; set; }

        [DisplayName("Days To Implement")]
        public int DaysToImplement { get; set; }

        [DisplayName("Reinstate Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReinstateDate { get; set; }

        [DisplayName("Status")]
        public String Status { get; set; }

        public WorkItemStatus WorkItemStatus { get; set; }

        [UIHint("RepDropDown")]
        [DisplayName("Enrollment Rep")]
        public String EnrollmentRep { get; set; }

        [UIHint("RepDropDown")]
        [DisplayName("Testing Rep")]
        public String TestingRep { get; set; }

        [DisplayName("Kick Off Call Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? KickOffCallDate { get; set; }

        [DisplayName("Sent To Madaket")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EnrollmentSentToThirdParty { get; set; }

        [DisplayName("Client Submission Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ClientSubmissionDate { get; set; }

        [DisplayName("Paperwork Received")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? PaperworkReceived { get; set; }

        [DisplayName("TAF Received Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? TAFReceivedDate { get; set; }

        [DisplayName("Paperwork Sent To Payer")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? PaperworkSentToPayer { get; set; }

        [DisplayName("Intro Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? IntroDate { get; set; }

        [DisplayName("Install Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? InstallDate { get; set; }

        [DisplayName("Testing Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? TestingDate1 { get; set; }

        [DisplayName("Production Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ProductionDate { get; set; }

        [DisplayName("Install Type")]
        public String InstallType { get; set; }

        [DisplayName("Notes")]
        public String Notes { get; set; }

        [DisplayName("Attachments")]
        public IList<Int64> Attachments { get; set; }

        [DisplayName("Created")]
        public DateTime? Created { get; set; }

        [DisplayName("Modified")]
        public DateTime? Modified { get; set; }

        [DisplayName("Last Modified By")]
        public String ModifiedBy { get; set; }

        [DisplayName("Last Sent")]
        public String WelcomeEmailLastSent { get; set; }

        public EnrollmentDetailsModel EnrollmentDetails { get; set; }

        public int Weight { get; set; }

        public bool IsActive { get; set; }

    }
}