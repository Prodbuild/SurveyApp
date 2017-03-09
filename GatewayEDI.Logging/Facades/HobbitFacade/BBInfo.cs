using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigBrotherFacade
{
    public class BBInfo
    {
        public Status Status { get; set; }
        public string Message { get; set; }

        public BBInfo(Status status, string message)
        {
            this.Status = status;
            this.Message = message;
        }
    }
}
