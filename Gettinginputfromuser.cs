using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main()
        {
            string firstName, lastName;
            Console.WriteLine("enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Full Name:" + firstName + " " + lastName);
        }
    }
}
