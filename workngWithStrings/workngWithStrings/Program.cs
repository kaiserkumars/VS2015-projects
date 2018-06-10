using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Standard NUmeric String Format on Bing.com

namespace workngWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life in \nnew line? Go to your C:\\Drive";
            //Console.Write(@"Go to your C:\Drive ");
            //string myString = String.Format("{1}={0}", "First", "Second");
            //string myString = string.Format("{0:C}", 123.45);
            string myString = string.Format("{0:N}", 1234.56);
            //string myString = string.Format("{0:P}", .123);
            //string myString = string.Format("Phone Number-- {0:(###) ###-####}", 1234567890);

            //string myString = "  That summer we took threes across the river  ";
            // myString = myString.Substring(6,14);
            //myString = myString.ToUpper();
            // myString = myString.Replace(" ", "--");

            //myString = myString.Remove(6, 14);
            //myString = string.Format("Length brfore: {0} - - Length after: {1}", myString.Length, myString.Trim().Length);


            /*
            string myString = "";
            for(int i=0;i<100;i++)
            {
                myString += "--" + i.ToString();
            }
            */
             
            
            /*
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            */
            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
