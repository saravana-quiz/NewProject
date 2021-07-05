using System;

namespace Parameterizedoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 0;
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            foreach (char chr in str)
            {
                len += 1;
            }
            Console.WriteLine("length of the entered string is:{0}", len);
        }
    }
}
