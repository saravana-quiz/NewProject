using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_Account
{
    class PanValidation
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
