using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Nissan";
            car1.Model = "GTR";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prime";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-0000-0";
            */



            //1. OLd type collection
            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);

            myArrayList.Add(b1); //will cause exception because b1 is of different data type
            myArrayList.Remove(b1);//remedy for above problem
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);

            }
            */



            //2. Generic Collection
            /*
            List<Car> myList = new List<Car>(); //specific to car datatype
            myList.Add(car1);
            myList.Add(car2);
            // myList.Add(b1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */



            //3. Generic Collection
            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make); 
            */

            //Object Initializer Syntax
            /*
            Car car1c = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            Car car2 = new Car() { Make = "Nissan", Model = "Jnjakn", VIN"HGH3" }; */

            //Collection Initializer

            List<Car> myList = new List<Car>()
            {
                new Car {Make = "Ols", Model= "aafa", VIN="XAS1" },  //object initializers
                new Car {Make = "Nissan" ,Model="ajsdn", VIN="SDR5" }
            };

            



            Console.ReadLine();



        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

   class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
