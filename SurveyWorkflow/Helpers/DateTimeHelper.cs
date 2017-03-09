using System;

namespace EnrollmentWorkflow.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime AddBusinessDays(this DateTime dateTime, int days)
        {
            DateTime temp = dateTime;

            for (int i = 0; i < days; i++)
            {
                do
                {
                    temp = temp.AddDays(1);
                }
                while (temp.DayOfWeek == DayOfWeek.Saturday || temp.DayOfWeek == DayOfWeek.Sunday);
            }

            return temp;
        }
    }
}