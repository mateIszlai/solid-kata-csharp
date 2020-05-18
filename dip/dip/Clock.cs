using System;

namespace dip
{
    public class Clock
    {
        public MonthDay MonthDay
        {
            get
            {
                var date = DateTime.Today;
                return new MonthDay { Day = date.Day, Month = date.Month };
            }
        }
    }
}
