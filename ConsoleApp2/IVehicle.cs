namespace ConsoleApp2
{
    interface IVehicle
    {
        string Name { get; }

        double Price { get; set; }

        int GetSpeed();

        void PrintInfo();
    }
}