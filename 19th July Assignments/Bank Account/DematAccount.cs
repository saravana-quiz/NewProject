using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class DematAccount : SalaryAccount,IDematBenifits           //Demat Account class with constructor
    {
        private string _panNumber;
        public DematAccount(int id, string name, double salary, string panNumber,string demandDraft,string locker) : base(id, name, salary, demandDraft, locker)
        {
            this._panNumber = panNumber;
        }
        public void DematAccountStatus()
        {
            SalaryAccountStatus();

            AvailFreeCreditScoreCheck();

            GetDailyStockUpdates();

            Console.WriteLine($"\n\nDemat account created successfully.\nAccount information \n\t Pan Number: {_panNumber}");
        }
        public void AvailFreeCreditScoreCheck()
        {     
            Console.WriteLine("Free Credit Score is Availed Sucessfully");
        }
        public void GetDailyStockUpdates()
        {
            Console.WriteLine("Todays Stock Updates");

        }
    }
}


