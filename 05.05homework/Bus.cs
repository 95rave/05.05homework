using System;
using System.Collections.Generic;
using System.Text;

namespace _05._05homework
{
    class Bus: Vehicle
    {
        public byte PassengerCount;
        public Bus()
        {

        }
        public Bus(string brand, string model, string color, ushort maxspeed, byte passengercount): base (brand, model, color, maxspeed)
        {
            PassengerCount = passengercount;

        }
        public override string Info()
        {
            if(string.IsNullOrEmpty(Brand) || string.IsNullOrWhiteSpace(Brand)|| string.IsNullOrEmpty(Model) || string.IsNullOrWhiteSpace(Model))
            {
                return $"Vhicle not found";
            }
            else
            {
                return $"Brand: {Brand} Model: {Model} Color: {Color} MaxSpeed: {MaxSpeed} PassengerCount: { PassengerCount}";
            }
        }

       
    }
}
