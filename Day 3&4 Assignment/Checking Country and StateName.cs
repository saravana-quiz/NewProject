using System;

namespace Checking_Country_and_state_Name
{
    class Program
    {
        //enumeration is used to define the data
        enum CountryStateName
        {
            India,Kerala,INDIA,KERALA
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the country Name: ");
            var countryName = Console.ReadLine();

            //converting enum values into string and stored it in the nue variable
            var country = Convert.ToString(CountryStateName.India);
            var countryCap = Convert.ToString(CountryStateName.INDIA);
            var state = Convert.ToString(CountryStateName.Kerala);
            var stateCap = Convert.ToString(CountryStateName.KERALA);
            //if condition is used to check the given values are same

            if (countryName == country || countryName == countryCap)
            {
                Console.WriteLine("Enter the State Name: ");
                var stateName = Console.ReadLine();
                if (stateName == state || stateName == stateCap)
                {
                    Console.WriteLine("True: Access Granted");
                }
                else
                    Console.WriteLine("False: State Name Not Found");
            }
            else
                Console.WriteLine("False: Country Not Found");
        }
    }
}
