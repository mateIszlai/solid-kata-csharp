using srp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
    public class Console : IConsole
    {
        public void PrintLine(string line)
        {
            System.Console.WriteLine(line);
        }
    }
}
