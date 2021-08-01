using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Interface
{
    class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("The Car is Driving");
            }
            else
            {
                Console.WriteLine("The has No Fuel Remaining to Start");
            }
        }

        public bool Refuel(int gasolineAmount)
        {
            Fuel += gasolineAmount;
            return true;
        }
    }
}
