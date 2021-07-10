using System;
using System.Collections;
using System.Collections.Generic;

/*Write a program which continuously takes input numbers from user. 
 If user types “Quit” then exit.Separate the duplicates 
and make a new list for unique numbers.*/ 

namespace Unique_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers: ");
            var names = new List<string>();
            //While(true) is the infinite loop created
            while (true)
            {
                var name1 = Console.ReadLine();
                if (name1 == "Quit")
                    break;
                names.Add(name1);

            }
            var uniqueList = new List<int>();

            //ArrayList is created to store the duplicate values
            var myNewArray = new ArrayList();
            for (int i = 0; i <names.Count; i++)
            {
                for (int j = i + 1; j < names.Count; j++)

                {
                    if (names[i] == names[j])

                        //Appending duplicate elements to ArrayList created
                        myNewArray.Add(names[j]);
                }
            }
            foreach(var n in names)
            {
                if(!myNewArray.Contains(n))
                {
                    uniqueList.Add(Convert.ToInt32(n));
                }
            }
            foreach( var h in uniqueList)
            {
                Console.WriteLine(h);
            }
        }
    }
}
