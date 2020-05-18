using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dip
{
    public interface IEmployeeRepository
    {
        List<Employee> findEmployeesBornOn(MonthDay monthDay);
    }

    public struct MonthDay : IEquatable<MonthDay>
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public bool Equals(MonthDay other)
        {
            return other.Month == Month && other.Day == Day;
        }
    }
}
