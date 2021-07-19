using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class SalaryAccount:IBenifits               //Salary Account class with constructor
    {
        private int _id;
        private string _name;
        private double _balance;
        private string _demandDraft;
        private string _locker;
        public SalaryAccount(int id, string name, double balance,string demandDraft, string locker)
        {
            this._id = id;
            this._name = name;
            this._balance = balance;
            this._demandDraft = demandDraft;
            this._locker = locker;
        }

        public void SalaryAccountStatus()
        {
            Console.WriteLine($"Salary Account is Created Sucessfully :\nUser Id :{_id} \nAccount Holder Name :{_name} \nCurrent Balance :{_balance}");
            AvailFreeDemandDraft();
            AvailFreeLocker();
        }
        public void AvailFreeDemandDraft()
        {
            if (_demandDraft == "yes")
            {
                Console.WriteLine("Free Demand Draft is Availed Sucessfully");
            }
            else
            {
                Console.WriteLine("Free Demand draft is Ignored");
            }
        }
        public void AvailFreeLocker()
        {
            if (_locker == "yes")
            {
                Console.WriteLine("Free Locker facility is Availed Sucessfully");
            }
            else
            {
                Console.WriteLine("Free Locker Facility is Ignored");
            }

        }
    }
}
