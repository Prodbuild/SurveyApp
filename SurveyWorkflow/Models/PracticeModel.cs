using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentWorkflow
{
    public class PracticeModel
    {
        public Int64 PracticeId { get; set; }
               
        public String TaxIdOrSsn { get; set; }

        public bool SharedTaxIdSsn { get; set; }
                
        public String BillingNpi { get; set; }

        public String PracticeName { get; set; }

        public String DoingBusinessAs { get; set; }

        public bool HasDBA { get; set; }

        public DateTime? GoLiveDate { get; set; }

        public bool GoLiveSoonAsPossible { get; set; }

        public String Address1 { get; set; }

        public String Address2 { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        public String Zip { get; set; }

        public String NoteTaxIdOrSsn { get; set; }

        public String NoteBillingNpi { get; set; }

        public String NotePracticeName { get; set; }

        public String NoteDoingBusinessAs { get; set; }

        public String NoteGoLiveDate { get; set; }

        public String NoteAddress1 { get; set; }

        public String NoteAddress2 { get; set; }

        public String NoteCity { get; set; }

        public String NoteState { get; set; }

        public String NoteZip { get; set; }
    }
}