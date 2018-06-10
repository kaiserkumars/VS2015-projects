using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };


            //LINQ Query
            /*
            var bmws = from car
                       in myCars
                       where car.Make == "BMW"
                       &&  car.Year==2010
                       select car;

    */
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010); //here acts as an instance, ie given p return all cars with Make == BMW

            //var usedd when we doesn't know what datatype is the variable            


            //LINQ method
            /*
            foreach (var car in bmws)  
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }*/


            /*
            var orderedCars = from car              //LINQ Query
                              in myCars
                              orderby car.Year descending
                              select car;

           */

            //var orderedCars = myCars.OrderByDescending(p => p.Year);   //LINQ method
            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            */

            /*
                        var firstBMW = myCars.First(p => p.Make == "BMW");
                        Console.WriteLine(firstBMW.VIN); */
            /*
                        var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
                        Console.WriteLine(firstBMW.VIN);
                        
                        */

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            // Console.WriteLine(myCars.Exists(p => p.Model =="745li"));

            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));


            //GetType()
            Console.WriteLine(myCars.GetType());

            var orderedCars = myCars.OrderByDescending(p => p.Year);   //LINQ method
            Console.WriteLine(orderedCars.GetType());

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010); //here acts as an instance, ie given p return all cars with Make == BMW
            Console.WriteLine(bmws.GetType());

            var newCars = from car
                       in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new{car.Make, car.Model };
            Console.WriteLine(newCars.GetType());  //Anonymous type

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
