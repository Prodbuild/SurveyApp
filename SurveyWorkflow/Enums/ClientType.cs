using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EnrollmentWorkflow.Helpers;

namespace EnrollmentWorkflow.Enums
{
    public enum ClientType
    {
        [EnumStringValue("New Client")]
        NewClient,

        [EnumStringValue("Child Site")]
        ChildSite,

        [EnumStringValue("PMS Change")]
        PMSChange
    }
}