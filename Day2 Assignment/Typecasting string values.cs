using System;

namespace Char_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //string values
            string idNo = "808";
            string nameOfEmployee = "BATMAN";
            string salaryPerMonth = "30000";

            //Typecasted string values
            int id = Convert.ToInt32(idNo);
            uint salary = Convert.ToUInt32(salaryPerMonth);

            // Displaying the typecasted value od ID and Salary
            Console.WriteLine("Typecasted string value of ID: " + id);
            Console.WriteLine("Typecasted string value of salary: " + salary);
        }
    }
}
