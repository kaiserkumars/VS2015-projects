using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicPrivateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.Dosmething();
            Console.ReadLine();
        }
    }

    class Car
    {
        public void Dosmething()
        {
            Console.WriteLine(helpermethod());
        }

        private string helpermethod()
        {
            return "Hello World!";
        }
    }
}
