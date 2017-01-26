using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class WashingMachine
    {
        public bool IsOn { get; set; }
        public string Model { get; set; }
        public double Time { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("FUCK NOT AGAIN");
            IsOn = true;
        }
    }
}
