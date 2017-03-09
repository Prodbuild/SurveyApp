using System;
using System.Configuration;

namespace EnrollmentWorkflow.Domain
{
    public class SettingsManager
    {
        public int MissingGoLiveEnrollment { get; set; }
        public int DaysAfterContractButStillEnrolling { get; set; }
        public int DaysAfterContractAndNotTesting { get; set; }
        public int MissingGoLiveTesting { get; set; }

        public SettingsManager()
        {
            MissingGoLiveEnrollment = Convert.ToInt32(ConfigurationManager.AppSettings["MissingGoLiveEnrollment"]);
            MissingGoLiveTesting = Convert.ToInt32(ConfigurationManager.AppSettings["MissingGoLiveTesting"]);
            DaysAfterContractAndNotTesting = Convert.ToInt32(ConfigurationManager.AppSettings["DaysAfterContractAndNotTesting"]);
            DaysAfterContractButStillEnrolling = Convert.ToInt32(ConfigurationManager.AppSettings["DaysAfterContractButStillEnrolling"]);
        }
    }
}
