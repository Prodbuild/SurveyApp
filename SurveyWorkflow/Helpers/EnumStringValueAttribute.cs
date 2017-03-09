namespace EnrollmentWorkflow.Helpers
{
    public class EnumStringValueAttribute : System.Attribute
    {
        private string _value;

        public EnumStringValueAttribute(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

    }
}