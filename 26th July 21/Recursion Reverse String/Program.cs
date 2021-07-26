using System;

namespace Recursion_String_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String to Reverse : ");

            string sentance = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nThe Reversed Sentance is : ");

            ReverseString reverseString = new ReverseString();

            reverseString.StringReversal(sentance);
            
        }
    }
}

