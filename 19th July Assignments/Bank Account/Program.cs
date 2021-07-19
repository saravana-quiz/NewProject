using System;
using System.Text.RegularExpressions;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to create the Salary Account and Enter 2 to create the Demat Account ");
            var type = Console.ReadLine();

            //To Create Salary Account Alone
            if (type == "1")
            {
                Console.WriteLine("Enter User Id :");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Accounbt Holder Name :");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Fixed Balance Amount :");
                double balance = Convert.ToDouble((Console.ReadLine()));

                Console.WriteLine("Enter'yes' to Avail Free DemandDraft");
                string demandDraft = Console.ReadLine();

                Console.WriteLine("Enter 'yes' to Avail Free Locker :");
                string locker = Console.ReadLine();

                SalaryAccount SalaryObj = new SalaryAccount(id, name, balance,demandDraft,locker);

                SalaryObj.SalaryAccountStatus();
            }

            //TO Create Demat Account
            else if (type == "2")
            {
                Console.WriteLine("Enter User Id :");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Accounbt Holder Name :");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Fixed Balance Amount :");
                double balance = Convert.ToDouble((Console.ReadLine()));

                Console.WriteLine("Enter Pan Card Number :");
                string panNumber = Console.ReadLine();

                Console.WriteLine("Enter 'yes' to Avail Free DemandDraft :");
                string demandDraft = Console.ReadLine();

                Console.WriteLine("Enter 'yes' to Avail Free Locker :");
                string locker = Console.ReadLine();

                PanValidation cardNumber = new PanValidation();
                cardNumber.panNumber = panNumber;
                string panCardNumber = cardNumber.panNumber;

                DematAccount dematDetails = new DematAccount(id, name, balance, panCardNumber,demandDraft,locker);
                dematDetails.DematAccountStatus();
            }
        }
    }
}

