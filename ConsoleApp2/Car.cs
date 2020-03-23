using System;

namespace ConsoleApp2
{
    public class Car
    {
        public Car(int id, string carName)
        {
            CarName = carName;
            ID = id;
        }


        public int ID { get; set; }

        public string CarName { get; set; }

        public double Price { get; set; }

        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);
            return Price - (saleSum / 100.0 * Price);
        }
    }
}