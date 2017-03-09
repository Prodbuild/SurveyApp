using System;

namespace GatewayEDI.InternalApps.Common.Validators
{
    public class GenericFieldValidator
    {
        public static ValidationMessage Validate<T>(T value, String member, String message, Func<T, bool> validator)
        {
            if (!validator(value))
            {
                var msg = new ValidationMessage
                {
                    Field = member,
                    Message = message
                };
                return msg;
            }

            return null;
        }
    }
}
