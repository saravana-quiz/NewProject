using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Signed integral data types
            int rollNumber = 8;
            long phoneNumber = 8825788888;
            short floor = 88;
            sbyte rank = 3;

            //Unsigned data types
            byte regNumber = 248;
            uint score = 1071;
            ushort employeeNumber = 888;
            ulong licenseNumber = 84845158151884858;

            //Real data types
            float percentage = 87.62f;
            double value = 0000.0000000088;
            decimal divisor = 2.00M;

            //Other value data types
            var age = 10;
            var name = "Saran";
            char grade = 'G';
            bool status = true;

            //Reference data types
            object mySkill = "C#";

            //Displaying Signed integral data types value
            Console.WriteLine("Roll Number value: " + rollNumber);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Floor No: " + floor);
            Console.WriteLine("Rank: " + rank);

            //Displaying Real data types value
            Console.WriteLine("Reg Number: " + regNumber);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Employee Number: " + employeeNumber);
            Console.WriteLine("License Number: " + licenseNumber);

            //Displaying Real data types value
            Console.WriteLine("Percentage: " + percentage);
            Console.WriteLine("Value: " + value);
            Console.WriteLine("Divisor: " + divisor);

            //Displaying Other value data types 
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Status: " + status);

            //Displaying Reference data types value
            Console.WriteLine("My Skill: " + mySkill);
        }
    }
}
