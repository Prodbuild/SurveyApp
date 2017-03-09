using System.Collections.Generic;

namespace GatewayEDI.InternalApps.Common.Validators
{
    public class ValidationResponse
    {
        public bool IsValid { get; set; }
        public List<ValidationMessage> Messages { get; set; }

        public ValidationResponse()
        {
            Messages = new List<ValidationMessage>();
        }
    }
}
