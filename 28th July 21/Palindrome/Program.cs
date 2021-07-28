using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, reverseStr = "";

            Console.WriteLine("Enter the String to check Palindrome");
            str = Console.ReadLine();

            for(int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i];
            }
            if (str == reverseStr)
            {
                Console.WriteLine("The Entered string is Palindrome");
            }
            else
            {
                Console.WriteLine("The Enterd string is not Palindrome");
            }
        }

    }
}
