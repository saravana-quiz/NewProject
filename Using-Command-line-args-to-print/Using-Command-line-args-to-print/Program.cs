using System;

namespace Using_Command_line_args_to_print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Name is " + args[0]);
            Console.WriteLine("Last Name is " + args[1]);
            Console.ReadLine();
        }
    }
}
