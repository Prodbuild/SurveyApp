using System;
using System.Collections.Generic;

namespace EnrollmentWorkflow.Models
{
    public class PracticePayerDetailModel
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String PayerId { get; set; }

        public bool Claims { get; set; }

        public String ClaimType { get; set; }

        public bool Remits { get; set; }

        public bool OffersRemits { get; set; }

        public bool NeedsProviderId { get; set; }

        public bool OnHold { get; set; }

        public String Message { get; set; }

        public String ProviderId { get; set; }

        public String NoteProviderId { get; set; }
    }
}