using System;

namespace _05._05homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus("bbjj", "djs", "Red", 160, 22);
            if (string.IsNullOrEmpty(bus.Brand) || string.IsNullOrWhiteSpace(bus.Brand) || string.IsNullOrEmpty(bus.Model) || string.IsNullOrWhiteSpace(bus.Model))
            {
                Console.WriteLine("Car wasn't  created");
            }
            else
            {
                Bus bus1 = new Bus();
            }
            
            Console.WriteLine(bus.Info());
        }
       
    }
}
