using System;

namespace DSA_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];
            int[] result = new int[numbers.Length];
            Console.Write($"Input {n} elements in the array :\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("element - {0}: ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int m = 0; m < numbers.Length; m++)
            {
                int remain = 0;

                for (int l = 0; l < numbers.Length; l++)
                {
                    if (m == l)
                    {
                        continue;
                    }
                    else
                    {
                        remain += numbers[l];

                    }
                }
                result[m] = remain;
            }

            foreach (var t in result)
            {
                Console.WriteLine($"Output : {t}");
            }

        }
    }

}

