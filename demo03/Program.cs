using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo03
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a new instance from Car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Nissan Skyline dr30 RS-X";
            car.Color = "Red";
            car.Engine = 2.0;
            car.Speed = 10;
            car.FuzzyDices = false;
            car.DoorCount = 2;
            car.Accelerate();
            car.PrintData();
            car.Brake(7);
            Car.SomeProperty = 56;
            car.PrintData();

            // create another car object
            string model = "Toyota Sprinter Trueno AE86";
            Car ae86 = new Car(model);
            ae86.PrintData();
            ae86.Color = "Panda";
            Console.WriteLine("Color is " + ae86.Color);
        }
    }
}
