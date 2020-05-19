using System;
using System.Collections.Generic;

namespace dip
{
    public interface IEmployeeRepository
    {
        List<Employee> findEmployeesBornOn(MonthDay monthDay);
    }

    public struct MonthDay
    {
        public int Month { get; set; }
        public int Day { get; set; }
    }
}
