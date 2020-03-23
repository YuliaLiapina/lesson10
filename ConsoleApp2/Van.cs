using System;

namespace ConsoleApp2
{
    public class Van : Car
    {
        private int mileage = 0;
        private int carrying = 100;
        private int maxCarrying = 5000;

        public Van(int carrying, int mileage, Insurance insurance, string carName, int id) : base(id, carName)
        {
            Carrying = carrying;
            Mileage = mileage;
            Insurance = insurance;
        }

        public Insurance Insurance { get; set; }

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
    }
}