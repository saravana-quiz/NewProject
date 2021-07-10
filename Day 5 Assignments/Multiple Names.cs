using System;
using System.Collections.Generic;

//Write a program which asks the user to enter multiple names until you press the enter button  (a blank name). Store them in a List.

namespace Multiple_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Names: ");
            var names = new List<string>();
            //While(true) is the infinite loop created
            while(true)
            {
                var name1 = Console.ReadLine();
                //if condition is used to check the string null or empty
                if (string.IsNullOrEmpty(name1) == true)

                    break; //break statement is used to break the loop created
                //Entered names are added to new List
                names.Add(name1);

            }
            if(names.Count>2)
            {
                Console.WriteLine($"{ names[0]},{names[1]} and {names.Count - 2} Peoples likes the post");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{ names[0]} and {names[1]} likes the post");
            }
            else if(names.Count == 1)
            {
                Console.WriteLine($"{ names[0]} likes the post");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
