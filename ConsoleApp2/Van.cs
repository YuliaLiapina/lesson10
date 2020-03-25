using System;

namespace ConsoleApp2
{
    public class Van : Car
    {
        private int mileage = 0;
        private int carrying = 100;
        private int maxCarrying = 5000;

        public Van(int mileage, int carrying, Insurance insurance, string carName, int id, double price) : base(carName, id, price)
        {
            Mileage = mileage;
            Carrying = carrying;
            Insurance = insurance;

        }
        public int Carrying
        {
            get => carrying;
            set
            {
                if (value < 0 || value > maxCarrying)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    carrying = value;
                }
            }
        }

        public int Mileage
        {
            get => mileage;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    mileage = value;
                }
            }
        }
        public Insurance Insurance { get; set; }
        public override int GetSpeed()
        {
            return 100;
        }
        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
        public override string Name => "Van";
    }
}