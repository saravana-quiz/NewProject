using System;

namespace Calculating_Different_data_types
{
    class Program
    {
        public static void Add()
        {
            Console.WriteLine("Enter the integer value : ");
            int intVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the decimal value : ");
            decimal Value =Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Addition of Integer and Decimal value : " + (intVal + Value));
        }
        public static void Divide()
        {
            Console.WriteLine("Enter the decimal value : ");
            decimal Value = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the integer value : ");
            int intVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing Decimal value with an Integer : " + (Value/intVal));
        }
        public static void Multiple()
        {
            Console.WriteLine("Enter the First Float value : ");
            float Value1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Second Float value : ");
            float Value2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Multiple of two float values : " + (Value1 * Value2));
        }
        public static void Main(string[] args)
        {
            Program.Add();
            Program.Divide();
            Program.Multiple();
     
        }
    }
    
}
