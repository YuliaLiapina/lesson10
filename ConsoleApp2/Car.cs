using System;

namespace ConsoleApp2
{
    public class Car : IVehicle,IDiscounts
    {
        public Car(string carName, int id, double price)
        {
            CarName = carName;
            ID = id;
            Price = price;
        }

        public string CarName { get; set; }
        public int ID { get; set; }
        public double Price { get; set; }

        public virtual string Name => "Car";
        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);
            return Price - (saleSum / 100.0 * Price);
        }

        public virtual int GetSpeed()
        {
            return 50;
        }
        public override string ToString()
        {
            return $"ID:{ID}, Name:{CarName}, Price:{Price}";
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}