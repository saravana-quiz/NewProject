using System;
using Domain;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = "Sample text";
                var result = Library.Occurance(text);
                Console.WriteLine($"{text} found in Occurance");
            }
            catch(TextNotFoundException g)
            {
                Console.WriteLine(g.Message);
            }
            Console.WriteLine("Enter Any Key to Exit");
            Console.ReadLine();
        }
    }
}
