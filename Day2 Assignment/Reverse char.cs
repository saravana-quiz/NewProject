using System;

namespace Reverse_string_values
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining char Variable names
            char firstChar, secondChar, thirdChar;

            //Getting char from the user
            Console.Write("Input letter: ");
            firstChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Input letter: ");
            secondChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Input letter: ");
            thirdChar = Convert.ToChar(Console.ReadLine());

            //Displaying the char in reverse order
            Console.WriteLine("{0} {1} {2}", thirdChar, secondChar, firstChar);
  
        }
    }
}
