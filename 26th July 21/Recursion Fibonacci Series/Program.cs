using System;

namespace Recursion
{
    class Program
    {
        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.Write(a + " ");
            if (counter < number)

                Fibonacci(b, a + b, counter + 1, number);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Number: ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nFibonacci Series of Entered number is : ");

            Fibonacci(0, 1, 1, number);
            Console.Read();         
            
        }
        
    }
}
