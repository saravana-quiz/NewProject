using System;

namespace Decimal_To_DMS
{
    class Program
    {
        public static int Hour(double degree)
        {
            return (int)Math.Floor(degree);

        }
        public static int Seconds(double degree)
        {
            double Seconds = Math.Round(60 * degree);
            return (int)Math.Round(Seconds);

        }

        public static void Minutes(double degree)
        {
            double Hour = Program.Hour(degree);
            double min = degree - Hour;
            double minute = min * 60;
            var minutes = (int)Math.Floor(minute);
            double seconds = minute - minutes;
            int Seconds = Program.Seconds(seconds);
            Console.WriteLine($"The Decimal degree {degree} coversion to DMS are :");
            Console.WriteLine("Hours :"+Hour);
            Console.WriteLine("Minutes :"+minutes);
            Console.WriteLine("Second :"+Seconds);

        }
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Decimal Degree value : ");
            double degree = Convert.ToDouble(Console.ReadLine());
            Program.Minutes(degree);
        }

    }
}
