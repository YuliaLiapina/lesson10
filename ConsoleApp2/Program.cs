using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
   public class Program
    {
       public static void Main(string[] args)
       {
           var cars = new List<Car>
           {
               new Minivan(5, "BMW", 1),
               new Van(
                   100,
                   100000,
                   new Insurance(DateTime.Now, DateTime.Now, "Yuliia Nechyporuk"),
                   "Lada",
                   10),
               new Minivan(5, "Kalina", 15)
           };

           foreach (var car in cars)
           {
               Console.WriteLine(car);
           }
       }
    }
}