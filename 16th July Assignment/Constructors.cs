using System;
using System.Text.RegularExpressions;

/*2.  Constructors

Create a base class SalaryAccount , when creating the account you must pass the fields like account Id, Name , Balance
Create a derived class DematAccount, when creating a demat account you must and should pass the Pan Card number. 
Try using the Regular expressions which you learnt in self learning to validate the pan card number  format. 
User should be able to create 
- SalaryAccount alone
- Salary Account along with the DematAccount */

namespace Constructors
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
                SalaryAccount SalaryObj = new SalaryAccount(id, name, balance);
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

                PanNumberValidation cardNumber = new PanNumberValidation();     
                cardNumber.panNumber = panNumber;            
                string panCardNumber = cardNumber.panNumber;

                DematAccount dematDetails = new DematAccount(id, name, balance, panCardNumber);
                dematDetails.DematAccountStatus();
            }
        }
    }
    class SalaryAccount  //Salary Account class with constructor
    {
        private int _id;
        private string _name;
        private double _balance;
        public SalaryAccount(int id, string name, double balance)
        {
            this._id = id;
            this._name = name;
            this._balance = balance;
        }

        public void SalaryAccountStatus()
        {
            Console.WriteLine($"Salary Account is Created Sucessfully :\nUser Id :{_id} \nAccount Holder Name :{_name} \nCurrent Balance :{_balance}");
        }
    }
    class DematAccount    //Demat Account class with constructor
    {
        private string _panNumber;
        private string _name;
        private int _id;
        private double _balance;
        public DematAccount(int id, string name, double balance, string panNumber) 
        {
            this._panNumber = panNumber;
            this._name = name;
            this._id = id;
            this._balance= balance;
        }
        public void DematAccountStatus()
        {
            Console.WriteLine($"\nSalary Account is created along with Demat Account Sucessfully :\nUser Id : {_id}\nAccount Holder Name :{_name}\nCurrent Balance :{_balance} \nPan Card Number : {_panNumber}");
        }
    }
    class PanNumberValidation
    {
        private string _panNumber;
        public string panNumber
        {
            get { return _panNumber; }
            set
            {
                while (true)   //Pan Number Validation
                {
                    Regex PanRegex = new Regex(@"[A-Z]{3}[P|C|H|A|B|G|J|L|F|T]{1}[A-Z]{1}\d{4}[A-Z]{1}");
                    Match match = PanRegex.Match(value);

                    if (match.Success)
                    {
                        this._panNumber = value;
                        break;
                    }
                    Console.WriteLine("Invalid Pan Card Number");
                    Console.WriteLine("Enter the valid Pan Card Number");
                    string panNumber = Console.ReadLine();
                    value = panNumber;
                }
            }
        }
    }
}
