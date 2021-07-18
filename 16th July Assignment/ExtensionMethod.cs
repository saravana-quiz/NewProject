using System;
using System.Text.RegularExpressions;

/*3.Extension method
  Create a class called Insurance, Add some methods like Pay premium.  
  Have few properties like name, email, Premium Due Date, aadhar card number. 
  Before creating an object, validate all inputs using the c# regular expressions.
  Create an extension method called GetDueDays which accepts the Insurance object  
  and returns the number of days pending to pay premium or number of days exceeded.*/

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation InuputValidation = new Validation();  

            Console.WriteLine("Enter Name :");          
            string name = Console.ReadLine();
            InuputValidation.Name = name;
            var Name = InuputValidation.Name;

            Console.WriteLine("Enter Email Address :");          
            string email = Console.ReadLine();
            InuputValidation.Email = email;
            var Email = InuputValidation.Email;

            Console.WriteLine("Enter Aadhar Number :"); 
            string aadharNumber = Console.ReadLine();
            InuputValidation.AadharNumber = aadharNumber;
            var AadharNumber = InuputValidation.AadharNumber;

            Insurance InsuranceObj = new Insurance();  
            InsuranceObj.PayPremium();
            var _dueDate = InsuranceObj.GetDueDays();  
            Console.WriteLine($"Insurance Plan :Premium\nName :{Name}\nEmail :{Email}\nAadharNumber :{AadharNumber}\n{_dueDate.Days} Days left for your Due Date");
        }
    }
    public class Insurance
    {
        public string Name { get; set; }
        public string email { get; set; }
        public double AadharNumber { get; set; }
        public DateTime DueDate { get; set; }

        public void PayPremium()
        {
            DateTime PayDate = DateTime.Now;
            DueDate = PayDate.AddDays(12);
        }
    }
    class Validation
    {
        private string _name;
        private string _email;
        private string _aadharNumber;
        public string Name
        {
            get { return _name; }
            set
            {
                while (true)                //Name Validation
                {
                    Regex Name = new Regex(@"^[A-Za-z]\w{3,20}$");
                    Match match = Name.Match(value);
                    if (match.Success)
                    {
                        this._name = value;
                        break;
                    }
                    Console.WriteLine("Invalid Name");
                    Console.WriteLine("Enter the valid Name");
                    string name = Console.ReadLine();
                    value = name;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                while (true)                 //Email Validation
                {
                    Regex Email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = Email.Match(value);
                    if (match.Success)
                    {
                        this._email = value;
                        break;
                    }
                    Console.WriteLine("Invalid Email");
                    Console.WriteLine("Enter the valid Email");
                    string email = Console.ReadLine();
                    value = email;
                }
            }
        }
        public string AadharNumber     
        {
            get { return _aadharNumber; }
            set
            {
                while (true)     //Aadhar Number Validation
                {
                    Regex Aadhar = new Regex(@"[^0]{1}\d{11}");
                    Match match = Aadhar.Match(value);
                    if (match.Success)
                    {
                        this._aadharNumber = value;
                        break;
                    }
                    Console.WriteLine("Invalid Aadhar Number");
                    Console.WriteLine("Enter the valid Aadhar Number");
                    string aadharNumber = Console.ReadLine();
                    value = aadharNumber;
                }
            }
        }
    }
    public static class ExtentionMethod
    {

        /*Extension Method which accepts the Insurance object  
        and returns the number of days pending to pay premium*/
        public static TimeSpan GetDueDays(this Insurance IObj)
        {
            var dueDate = IObj.DueDate;
            TimeSpan DaysLeft = dueDate - DateTime.Now;
            return DaysLeft;
        }
    }
}
