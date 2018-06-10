using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 9;
            numbers[3] = 11;
            numbers[4] = 16;
      
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            //int[] num = new int[] { 4, 5, 6, 7, 8, 9 };

            /*
            string[] names = new string[] { "dsfds", "dhdh", "dgdgg", "dgdg", "ghnyt" };
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            

            foreach (string  name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
            */

            string zig = " Hey!do you want somerthign gogoel then go to hell" +
                "and enjot jtkjs there";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            
            Console.ReadLine();

        }
    }
}
