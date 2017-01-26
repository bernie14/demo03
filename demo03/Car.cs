﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo03
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }

        // default constructor
        public Car()
        {

        }

        // constructor
        public Car(string model)
        {
            Model = model;
        }

        //method to gib speed
        public void Accelerate()
        {
            Speed += 10;
        }

        // method to take speed ewey

        public void Brake(int value)
        {
            Speed -= value;
        }

        // method to display car data/properties

        public void PrintData()
        {
            Console.WriteLine("Car properties: ");
            Console.WriteLine("- model: " + Model);
            Console.WriteLine("- color: " + Color);
            Console.WriteLine("- engine: " + Engine);
            Console.WriteLine("- speed: " + Speed);
            Console.WriteLine("- door count: " + DoorCount);
            Console.WriteLine("- some shit property: " + SomeProperty);
            Console.WriteLine("- dices: " + FuzzyDices);
        }

        // destructor
        ~Car()
        {
            Console.WriteLine("Car is kill. " + "No");
        }


    } // class
} // namespace
