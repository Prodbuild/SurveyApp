using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EnrollmentWorkflow.Helpers;

namespace EnrollmentWorkflow.Enums
{
    public enum CommunicationType
    {
        [EnumStringValue("Phone")]
        Phone,

        [EnumStringValue("Email")]
        Email,

        [EnumStringValue("Auto Email")]
        AutoEmail
    }
}