using System;

namespace Second_Largest_Number_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {    
            int[] arr = { 2, 6, 4, 2, 3, 9, 8, 18 };

            int largest = 0;
            int secondLargest = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if(num > secondLargest && num < largest)
                {
                    secondLargest = num;
                }
            }

            Console.WriteLine("Second Largest Number in the array is : " +secondLargest);
        }
    }
}
