using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Enter the any key between 1 to 10");

            int key = Convert.ToInt32(Console.ReadLine());

            int result=BinarySearch(arr, key);
            
            if(result == -1)
            {
                Console.WriteLine("Key is Not present in the array");
            }
            else
            {
                Console.WriteLine("Key is present in the array index :"+result);
            }
            
        }

        public static int BinarySearch(int[] arr,int key)
        {
            int minNumber = 0;
            int maxNumber = arr.Length - 1;
            
            while (minNumber <= maxNumber)
            {
                int mid = (minNumber + maxNumber) / 2;

                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    minNumber = mid + 1;
                }
                else 
                { 
                    maxNumber = mid - 1; 
                }     
            }
            return -1;

        }
    }
}
