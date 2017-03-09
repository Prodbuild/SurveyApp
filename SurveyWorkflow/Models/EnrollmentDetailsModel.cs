using System;
using System.Collections.Generic;

namespace EnrollmentWorkflow.Models
{
    public class EnrollmentDetailsModel
    {
        public IList<PracticeDetailsViewModel> PracticeDetails { get; set; }

        public String SiteId { get; set; }
    }
}
