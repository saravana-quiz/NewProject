using System;

namespace Compare_string_and_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting string and integer values to compare
            Console.WriteLine("Enter the FirstString: ");
            string color1 = Console.ReadLine();
            Console.WriteLine("Enter the SecondString: ");
            string color2 = Console.ReadLine();
            Console.WriteLine("Enter the integer value1: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the integer value2: "); 
            int value2 = Convert.ToInt32(Console.ReadLine());

            //Using "if" Codition to Compare Strings and integer
            if (color1 == color2 && value1 == value2)
            {
                bool result = true;
                Console.WriteLine("The result is: " + result);
            }
            //else condition displays false if any one of the comparision fails
            else
                Console.WriteLine("The result is: false");  
            
        }
    }
}
