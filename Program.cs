using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingInheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAR INFO
            car myNewCar = new car();
            myNewCar.Make = "Mini";
            myNewCar.Modle = "Sport";
            myNewCar.Year = 2016;
            myNewCar.Colour = "Grey & White";
            //Truck INFO
            Truck mynewtruck = new Truck();
            mynewtruck.Make = "Ford";
            mynewtruck.Modle = "Pick-up";
            mynewtruck.Year = 2001;
            mynewtruck.Colour = "Black";
            mynewtruck.towingCapacity = 1200;

            //METHODS
            //someMethod(myNewCar);
            //someMethod(mynewtruck);

            //Print to Console
            myNewCar.printMe();
            mynewtruck.printMe();

            Console.ReadLine();
        }

        //Method  - Send to Console
        //private static void someMethod(car car)
        //{
        //    Console.WriteLine("From Some Method {0}", car.Make);
        //}
    }

}

abstract class veavehicleInfo
{
    public String Make { get; set; }
    public String Modle { get; set; }
    public int Year { get; set; }
    public String Colour { get; set; }
    public int towingCapacity { get; set; }

    public abstract void printMe();
}

class car : veavehicleInfo
    {
        public override void printMe()
        {
        Console.WriteLine("{0} - {1}", this.Make, this.Modle);
        }
    }

    class Truck : veavehicleInfo
    {
        public override void printMe()
        {
        Console.WriteLine("{0} - {1}", this.Make, this.towingCapacity);
        }

    }

 

