using System;
using System.Collections.Generic;
using System.Text;

namespace _05._05homework
{
   abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public string Color;
        public ushort MaxSpeed;

        
        public Vehicle(string brand, string model)
        {
            if (string.IsNullOrEmpty(Brand) || string.IsNullOrWhiteSpace(Brand))
            {
                Console.WriteLine("Enter the name of the vehicle");
            }
            else
            {
                Brand = brand;
            }
            if (string.IsNullOrEmpty(Model) || string.IsNullOrWhiteSpace(Model))
            {
                Console.WriteLine("Enter the name of the model");

            }
            else
            {
                Model = model;
            }

            Brand = brand;
            Model = model;
        }
        public Vehicle(string brand, string model, string color, ushort maxspeed ): this(brand, model)
        {
            Color = color;
            MaxSpeed = maxspeed;
        }


        public abstract string Info();
        


        public Vehicle()
        {
            Console.WriteLine("Car Created");
        }
            
    }


    
    
}
