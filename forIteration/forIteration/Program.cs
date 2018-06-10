using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<10)
            {
                Console.WriteLine(i);
                if(7==i)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
                i++;
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }   
            Console.ReadLine();
        }
       
    }
}
