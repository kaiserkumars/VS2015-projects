using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            //Car myThirdCar = new Car("Ford", "Sdsd", 2005, "white");

            /*
            myCar.Maker = "a";
            myCar.Model = "b";
            myCar.Year = 122;
            myCar.Color = "blue";

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Maker, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);
*/
          //  myOtherCar.Model = "tata";
          /*
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Maker,
                myCar.Model,
                myCar.Year,
                myCar.Color);


            Console.WriteLine("{0} {1} {2} {3}",
                myThirdCar.Maker,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color);*/


            //  myOtherCar = null;

            /*
            Console.WriteLine("{0} {1} {2} {3}",
               myOtherCar.Maker,
               myOtherCar.Model,
               myOtherCar.Year,
               myOtherCar.Color);
               */

            Car.myMethod();

            myCar = null;
            Console.ReadLine();
        }
    }


     class Car
    {
        public string Model { get; set; }
        public string Maker { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /*
        public Car()
        {
            this.Maker = "Nissan";
        }

        public Car(string maker, string model, int year, string color)
        {
            Maker = maker;
            Model = model;
            Year = year;
            Color = color;
        }*/


        public static void myMethod()
        {
            Console.WriteLine("Called Static Method!");
            
        }
    }
}
