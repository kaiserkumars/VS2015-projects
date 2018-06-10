using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Giveaway");
            Console.WriteLine("Choose a Door 1,2,3");
            string userValue = Console.ReadLine();
            /* string message="";
             if ("1" == userValue)
             {
                 message = "You won a new Car!";

             }

             else if ("2" == userValue)
             {
                 message = "You won a new boat!";

             }

             else if ("3" == userValue)
             {
                 message = "You won a bike!";

             }

             else
                 message = "We didn't understand!!!";

             Console.WriteLine(message);
             Console.ReadLine();
             */

            string message = ("1" == userValue) ? "Boat" : "Linndi";
            Console.WriteLine("You entered: {0} Therefore You won a {1}",userValue, message); //Replacement
            Console.ReadLine();

        }
    }
}
