using srp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
    public class Clock : IClock
    {
        public DateTime Today()
        {
            return DateTime.Today;
        }
    }
}
