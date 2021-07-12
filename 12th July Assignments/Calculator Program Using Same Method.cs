using System;
using System.Collections.Generic;

namespace Calculator_Program_Using_Same_Method_Names
{
    class Program
    {
        public static int Calculation(string Choice,int firstValue,int secondValue)
        {
            if (Choice == "Subtraction")
            {
                int result = firstValue - secondValue;
                return result;
            }
            else if (Choice == "Division")
            {
                int result = firstValue / secondValue;
                return result;
            }
            else
                return 0;
        }
        public static int Calculation(String Choice, params string[] List)
        {
            if (Choice == "Addition")
            {
                int result = 0;
                foreach (var i in List)
                {
                    result += int.Parse(i);

                }
                return result;

            }
            else if (Choice == "Multiplication")
            {
                int result = 1;
                foreach (var j in List)
                {
                    result *= Convert.ToInt32(j);
                }
                return result;

            }
            else
                return 0;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers for Addition :");
            var input = Console.ReadLine();
            string[] newList = input.Split(",");
            string Choice = "Addition";
            var result1 = Program.Calculation(Choice, newList);
            Console.WriteLine("The Addtion Result = " + result1);

            Console.WriteLine("Enter the Numbers for Multiplication :");
            var input1 = Console.ReadLine();
            string[] newList1 = input1.Split(",");
            string Choice1 = "Multiplication";
            var result12 = Program.Calculation(Choice1, newList1);
            Console.WriteLine("The Multiplication Result = " + result12);


            Console.WriteLine("Enter the First Value for Subtraction :");
            var firstVal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Value for Subtraction :");
            var secondVal = int.Parse(Console.ReadLine());
            string Choice2 = "Subtraction";
            var result2 = Program.Calculation(Choice2, firstVal,secondVal);
            Console.WriteLine("The Subtraction Result = " + result2);

            Console.WriteLine("Enter the  First Value for Division :");
            var firstVal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Value for Division :");
            var secondVal2 = int.Parse(Console.ReadLine());
            string Choice3 = "Division";
            var result3 = Program.Calculation(Choice3, firstVal1, secondVal2);
            Console.WriteLine("The Subtraction Result = " + result3);
        }
    }
}
