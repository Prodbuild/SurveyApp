using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentWorkflow.Models
{
    public class WorkItemReportModel
    {
        public string RepSamName { get; set; }

        public string RepDisplayName { get; set; }

        public double ADI { get; set; }

        public int OpenWorkItems {get; set;}

        public int OutsideSLA {get; set;}
    }
}