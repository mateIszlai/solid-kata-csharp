using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp
{
    public class Bird : IAnimal
    {
        public void bark() { }
        public void run()
        {
            Console.WriteLine("Bird is running");
        }
        public void fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}
