using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
   public class Program
    {
       public static void Main(string[] args)
       {
            var vehicles = new List<IVehicle>
           { new Van(10,250, new Insurance(DateTime.Now, DateTime.Now,"Elena"),"Van",12345,1200),
            new Minivan(40,"Minivan",3546,20000),
            new Bicycle()};

            foreach (var car in vehicles)
            {
                Console.WriteLine(car.Name + " ");
                Console.WriteLine("Speed :" + car.GetSpeed());
            }

            IVehicle van = new Van(
               100,
               100000,
               new Insurance(DateTime.Now, DateTime.Now, "Yuliia Nechyporuk"),
               "Lada",
               10,
               12000);

            van.PrintInfo();

            IVehicle plane = new Airplane();
            plane.Price = 300;

            plane.PrintInfo();

            IDiscounts plane1 = new Airplane();
            plane1.GetSale();

            Console.ReadKey();
        }
    }
}