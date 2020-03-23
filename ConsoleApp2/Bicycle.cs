using System;

namespace ConsoleApp2
{
    public class Bicycle : IVehicle
    {
        public string Name => "Bicycle!";

        public int GetSpeed()
        {
            return 15;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(Name);
        }
    }
}