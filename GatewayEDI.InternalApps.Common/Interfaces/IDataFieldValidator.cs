using System;
using System.Collections.Generic;
using GatewayEDI.InternalApps.Common.Validators;

namespace GatewayEDI.InternalApps.Common.Interfaces
{
    public interface IDataFieldValidator<in T>
    {
        List<ValidationMessage> Validate(T toValidate, String memberName);
    }
}
