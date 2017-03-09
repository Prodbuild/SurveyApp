using System.Collections.Generic;

namespace EnrollmentWorkflow.Models
{
    public class PracticeDetailsViewModel
    {
        public PracticeModel PracticeInfo { get; set; }

        public IList<PracticePayerDetailModel> PayerInfo { get; set; }

        public IList<ProviderModel> ProviderInfo { get; set; }
    }
}