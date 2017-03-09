using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentWorkflow.Models
{
    public class ProviderModel
    {
        public int Id { get; set; }
       
        public String TaxIdOrSsn { get; set; }

        public String FirstName { get; set; }

        public String MiddleInitial { get; set; }

        public String LastName { get; set; }

        public String Specialty { get; set; }

        public String ProviderTitle { get; set; }

        public String IndividualRenderingNpi { get; set; }

        public bool IsIndividual { get; set; }

        public String NoteTaxIdOrSsn { get; set; }

        public String NoteFirstName { get; set; }

        public String NoteMiddleInitial { get; set; }

        public String NoteLastName { get; set; }

        public String NoteSpecialty { get; set; }

        public String NoteProviderTitle { get; set; }

        public String NoteIndividualRenderingNpi { get; set; }

    }
}