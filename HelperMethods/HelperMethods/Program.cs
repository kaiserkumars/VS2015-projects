using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = inputData();
            

            Console.Write("What's your last name? ");
            string lastName = inputData();
            


            Console.Write("In what city were you born?");
            string city = inputData();

    
            //Console.WriteLine("Results: " + result);
            result(reverse(firstName), reverse(lastName), reverse(city));

            Console.ReadLine();

        }

        private static string inputData()
        {
            string details;
            details = Console.ReadLine();
            return details;
        }


        private static string reverse(string details)
        {
            char[] charDetails = details.ToCharArray();
            Array.Reverse(charDetails);
            return String.Concat(charDetails);
        }

        private static void result(string reversedFirstName,
            string reversedlastName, 
            string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}",
               reversedFirstName,
               reversedlastName,
               reversedCity));
        }
    }
}
