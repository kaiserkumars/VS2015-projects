using System;
using System.Net;

namespace uderstandingNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string text = "A class is the most powerfull thing in the c#, A class described the data adn behaviour of the data type";
            System.Console.WriteLine("Hello World!");
            WebClient client = new WebClient();
            string address = "https://msdn.microsoft.com";
            string reply = client.DownloadString(address);
            System.IO.File.WriteAllText(@"D:\sample.txt", reply);
            Console.WriteLine(reply);
            Console.ReadLine();

        }
         
            
        
    }
}
