using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // first washing machine
            WashingMachine wishwash = new WashingMachine();
            wishwash.Model = "Muzis pesukone";
            Console.WriteLine("mashiinan malli: " + wishwash.Model);
            wishwash.IsOn = false;
            Console.WriteLine("wishwash mashiin is on? " + wishwash.IsOn);
            wishwash.Time = 666;
            wishwash.TurnOn();
            Console.WriteLine("wishwash mashiin on? " + wishwash.IsOn);

            // another washing machine
            WashingMachine washer666 = new WashingMachine();
            washer666.Model = "Parempi pesukone";
            Console.WriteLine("mashiinan malli: " + washer666.Model);
            washer666.IsOn = false;
            Console.WriteLine("washer mashiin is on? " + wishwash.IsOn);
            washer666.Time = 101001010101010101010;
            washer666.TurnOn();
            Console.WriteLine("washer mashiin on? " + wishwash.IsOn);
        }
    }
}
