using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EnrollmentWorkflow.Helpers.DataAnotationsExtensions;

namespace EnrollmentWorkflow.Models
{
    public class NewWorkItem
    {
        [DisplayName("Site Id")]
        [Required(ErrorMessage = "SiteId is required")]
        [MinLength(4)]
        [MaxLength(4)]
        public string SiteId { get; set; }

        [DisplayName("Vendor")]
        [Required(ErrorMessage = "Vendor is required")]
        public int Vendor { get; set; }

        [DisplayName("Doc Type")]
        [DefaultValue(null)]
        [ValidInteger(ErrorMessage = "Please enter valid number for Doc Type")]
        public int? DocType { get; set; }

        [DisplayName("Office Name")]
        [Required(ErrorMessage = "Office Name is required")]
        public string OfficeName { get; set; }

        [DisplayName("Install Type")]
        [DefaultValue(null)]
        [ValidInteger(ErrorMessage = "Please enter valid number for Install type")]
        public int? InstallType { get; set; }

        [DisplayName("Project Manager")]
        public string ProjectManager { get; set; }

        [DisplayName("Ecw Group")]
        public string EcwGroup { get; set; }

        [UIHint("RepDropDown")]
        [DisplayName("Enrollment Rep")]
        public string EnrollmentRep { get; set; }


        [DisplayName("Contract Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Contract Date is required")]
        public DateTime ContractDate { get; set; }
    }
}