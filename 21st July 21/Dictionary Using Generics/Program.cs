using System;
using System.Collections.Generic;


/*1.  Generics

Create your own  Dictionary which takes key , value pairs of type Generics. 
Support methods like  Add, Remove and Sort.  Try this out on various user defined types. */

namespace Dictionary_Using_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics<int, string> genericList = new Generics<int, string>();
            genericList.Add(8, "Richy Reginald");
            genericList.Add(4, "Roshan");
            genericList.Add(1, "Arun");
            genericList.Add(2, "Black");
            genericList.Add(5, "Dravid");
            genericList.Add(3, "Messi");
            genericList.Add(7, "Ronaldo");
            genericList.Add(6, "Sam");

            genericList.Remove(7);

            genericList.sort();

            Generics<string, double> genericList1 = new Generics<string, double>();
            genericList1.Add("Tom Holland", 8000);
            genericList1.Add("Dwayne Johnson", 88000);
            genericList1.Add("Rock", 20000);
            genericList1.Add("Chris Hemsworth", 80000);
            genericList1.Add("Johnny Depp", 12005);
            genericList1.Add("Jarvis", 16652);
            genericList1.Add("robert downey jr", 180000);
            genericList1.Add("Chris Evans", 190000);

            genericList1.sort1();
        }
    }
}
