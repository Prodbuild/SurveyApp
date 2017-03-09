using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GatewayEDI.InternalApps.Common.Validators;

namespace GatewayEDI.InternalApps.Common.Interfaces
{
    public interface IDataValidator<in T>
    {
        List<ValidationMessage> Validate(T toValidate);
       
    }
}
