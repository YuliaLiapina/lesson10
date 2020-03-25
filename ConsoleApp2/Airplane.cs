using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Airplane : IVehicle, IDiscounts
    {
        public string Name => "Plane";

        public double Price { get; set; }

        public int GetSpeed()
        {
            return 200;
        }

        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"{Name}\t{Price}\t{GetSpeed()}";
        }
        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);
            return Price - (saleSum / 100.0 * Price);
        }
    }
}
