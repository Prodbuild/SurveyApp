using System;
using GatewayEDI.InternalApps.Common.Validators;

namespace GatewayEDI.InternalApps.Common.Interfaces
{
    public interface IDateRangeValidator
    {
        ValidationResponse ValidateDateRange(DateTime startDate, DateTime endDate);
    }
}
