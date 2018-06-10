using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient c = new WebClient();
            var data = c.DownloadString("https://restcountries.eu/rest/v1/all");
            //Console.WriteLine(data);
            JArray v = JArray.Parse(data);


            /**** Simply printing one element 
            var C1 = v[1]["name"].ToString();
            Console.WriteLine("Country:" + C1);
            ***/


            /*** Access all elements 
            var items = from p in v
                        select (string)p["name"];
            foreach (var country in items)
            {
                Console.WriteLine(country);
            }
            ***/


            Console.ReadLine();
        }
    }
}
