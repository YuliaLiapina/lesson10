using System;

namespace ConsoleApp2
{
    public class Minivan : Car
    {
        private int maxNumberOfSeats = 10;
        private int numberOfSeats = 4;

        public Minivan(int numberOfSeats, string carName, int id) : base(id, carName)
        {
            NumberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats
        {
            get => numberOfSeats;
            set
            {
                if (value < 0 || value > maxNumberOfSeats)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    numberOfSeats = value;
                }
            }
        }
    }
}