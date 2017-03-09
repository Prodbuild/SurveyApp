using System;
using GatewayEDI.InternalApps.Common.Interfaces;

namespace GatewayEDI.InternalApps.Common.Validators
{
    public class DateRangeValidator : IDateRangeValidator
    {
        public ValidationResponse ValidateDateRange(DateTime startDate, DateTime endDate)
        {
            var rt = new ValidationResponse {IsValid = true};
            
            if ( endDate.Date > DateTime.Today)
            {
                rt.IsValid = false;
                rt.Messages.Add(new ValidationMessage{Field = "endDate", Message = "EndDate cannot be future date."});             
            }

            if (startDate > endDate)
            {
                rt.IsValid = false;
                rt.Messages.Add(new ValidationMessage { Field = "startDate", Message = "Start Date cannot be greater than End date." });    
            }

            return rt;
        }
    }
}
