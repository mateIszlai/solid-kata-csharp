using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp
{
    public class Dog : IAnimal
    {
        public void fly()
        {

        }

        public  void run()
        {
            Console.WriteLine("Dog is running");
        }

        public void bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
