using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choice = true;
            while (choice==true)
            {
                choice=MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guess Numbers");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if ("1" == result)
            {
                printNumbers();
                return true;
            }
            else if ("2" == result)
            {
                Guess();
                return true;
            }
            else if ("3" == result)
                return false;
            else
                return true;




        }

        private static void printNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            while(counter<=num)
            {
                Console.Write(counter);
                counter++;
            }
            Console.ReadLine();

        }

        private static void Guess()
        {
            Console.WriteLine("Guess numbers");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("wrong!");
                guesses++;

            } while (incorrect == true);
            Console.WriteLine("it took you {0} guesses!", guesses);
            Console.ReadLine();
        }





    }
}
