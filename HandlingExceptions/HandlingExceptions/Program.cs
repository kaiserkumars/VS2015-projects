using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program  //lookout msdn for ecxeptions of ReadAlltext
    {
        static void Main(string[] args)
        {
            
            try
            {
                string content = File.ReadAllText(@"D:\abd.txt");
                Console.WriteLine(content);
                
            }


            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was problem!");
                Console.WriteLine("Make sire the file name is correct..");
                Console.WriteLine(ex.Message);
            }

            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was problem!");
                Console.WriteLine("Make sire the directory name is correct..");
            }

            finally
            {
                //code to finalize seeting objects to null
                //Clasing database connections
                Console.WriteLine("CLosing app now....");
            }
            Console.ReadLine();


        }
    }
}
