using System;
using System.Collections;

namespace Store_Duplicates_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elements in the integer array with duplicate values
            int[] value = new int[] { 3, 4, 3, 8, 9, 9, 8 };

            //ArrayList is created to store the duplicate values
            var myNewArray = new ArrayList();
            for (int i = 0; i < value.Length; i++)
            {
                for (int j = i + 1; j < value.Length; j++)
                    
                {
                    if (value[i] == value[j])

                       //Appending duplicate elements to ArrayList created
                       myNewArray.Add(value[j]);
                }
            }
            foreach (var val in myNewArray)
            {
                Console.WriteLine("Duplicate Element in the given Array"+val);
            }
        }
    }
}
