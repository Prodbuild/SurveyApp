using System.Collections.Generic;

namespace EnrollmentWorkflow.Models
{
    public class HomeModel
    {
        public int MissingGoLive { get; set; }
        public int MissingDaysToImplement { get; set; }
        public double AverageDaysToImplement { get; set; }
        public int SitesInImplementation { get; set; }

        public List<WorkItemCategoryModel> WorkItemCategories { get; set; } 
    }
}