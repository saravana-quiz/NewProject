using System;

namespace Car_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);

            Console.WriteLine("Enter the amount for Refuel");

            int fuel = int.Parse(Console.ReadLine());

            if(car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}
