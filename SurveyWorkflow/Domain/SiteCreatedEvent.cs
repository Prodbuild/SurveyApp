namespace EnrollmentWorkflow.Domain
{
    public class SiteCreatedEvent
    {
        public string Email { get; set; }
        public string OfficeName { get; set; }
        public long VendorNumber { get; set; }
    }
}