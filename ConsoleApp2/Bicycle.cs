using System;

namespace ConsoleApp2
{
    public class Bicycle : IVehicle,IDiscounts
    {
        public string Name => "Bike";

        public double Price { get; set; }
        public int GetSpeed()
        {
            return 40;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Bike!");
        }

        public double GetSale()
        {
            return 50;
        }
    }
}