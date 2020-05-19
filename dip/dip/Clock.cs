using System;

namespace dip
{
    public class Clock : IClock
    {
        public MonthDay MonthDay()
        {
            var date = DateTime.Today;
            return new MonthDay { Day = date.Day, Month = date.Month };
        }
    }
}
