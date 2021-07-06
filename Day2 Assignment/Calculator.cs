using System;

namespace Calculator
{
    class Program
    {
        //Main function
        public static void Main(string[] args)
        {
            /*Getting firstline as value1 and second line as value2 and third line input as arithmetic operator to perform calculation*/
            int result = 0;
            string operend;
            Console.WriteLine("Enter the first Value: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Value: ");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Arithmetic operator to perform calculation: ");
            operend = Console.ReadLine();

            //Switch case is used to perform the specific arithmetic operation
            switch (operend)
            {
                case "+":
                    {
                        result = Addition(firstValue, secondValue);
                        break;
                    }
                case "-":
                    {
                        result = Subtraction(firstValue, secondValue);
                        break;
                    }
                case "*":
                    {
                        result = Multiplication(firstValue, secondValue);
                        break;
                    }
                case "/":
                    {
                        result = Division(firstValue, secondValue);
                        break;
                    }
                case "%":
                    {
                        result = Modulo(firstValue, secondValue);
                        break;
                    }
            }

            //Displaying the calculated result
            Console.WriteLine("The Result is: " + result);
            Console.ReadKey();
        }


        //Declaring Addition Method
        public static int Addition(int firstValue, int secondValue)
        {
            int result = firstValue + secondValue;
            return result;
        }

        //Declaring Subtraction Method
        public static int Subtraction(int firstValue, int secondValue)
        {
            int result = firstValue - secondValue;
            return result;
        }

        //Declaring Multiplication Method
        public static int Multiplication(int firstValue, int secondValue)
        {
            int result = firstValue * secondValue;
            return result;
        }

        //Declaring Division Method
        public static int Division(int firstValue, int secondValue)
        {
            int result = firstValue / secondValue;
            return result;
        }

        //Declaring Modulo Method
        public static int Modulo(int firstValue, int secondValue)
        {
            int result = firstValue % secondValue;
            return result;
        }

    }
}

