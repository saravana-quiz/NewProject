using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    class InsuranceProcess
    {
        public static List<Customer> AddCustomer()
        {
            List<Customer> customerList = new List<Customer>
                {

                new Customer { CustomerID = "1", Name = "Kishore", Age = 25, BloodGroup = "B+"},
                new Customer { CustomerID = "2", Name = "Deepika", Age = 22, BloodGroup = "AB+"},
                new Customer { CustomerID = "3", Name = "Ram", Age = 28, BloodGroup = "O-"},
                new Customer { CustomerID = "4", Name = "Tharun", Age = 28, BloodGroup = "B-"},
                new Customer { CustomerID = "5", Name = "Sam", Age = 45, BloodGroup = "O+"}

                };

            return customerList;
        }
        public static List<InsuranceDetails> AddInsurance()
        {
            List<InsuranceDetails> finalList = new List<InsuranceDetails>
            {

                new InsuranceDetails{CustomerID = "1", InsuranceID = "152525", Age = 25, Validity = 2, MedicalInsurance = true, LifeInsurance = true},
                new InsuranceDetails{CustomerID = "2", InsuranceID = "128288", Age = 22, Validity = 1, MedicalInsurance = true, LifeInsurance = true},
                new InsuranceDetails{CustomerID = "3", InsuranceID = "188822", Age = 28, Validity = 2, MedicalInsurance = false, LifeInsurance = false},
                new InsuranceDetails{CustomerID = "4", InsuranceID = "162588", Age = 28, Validity = 2, MedicalInsurance = true , LifeInsurance = false},
                new InsuranceDetails{CustomerID = "5", InsuranceID = "182828", Age = 45, Validity = 1, MedicalInsurance = true , LifeInsurance = false}

            };

            return finalList;
        }

        public void AddDetails()
        {
            var customerList = AddCustomer();

            var insuranceList = AddInsurance();

            List<string> customerName = new List<string>();

            List<MedicalInsurance> list = new List<MedicalInsurance>
            {
                new MedicalInsurance {Name = "Karan", PremiumAmount = 800000, AppointmentsCompleted = 1},
                new MedicalInsurance {Name = "Deepika", PremiumAmount = 600000, AppointmentsCompleted = 2},
                new MedicalInsurance {Name = "Tharun", PremiumAmount = 900000, AppointmentsCompleted = 2},
                new MedicalInsurance {Name = "Roshan", PremiumAmount = 500000, AppointmentsCompleted = 1},
                new MedicalInsurance {Name = "Richy", PremiumAmount = 6000000, AppointmentsCompleted = 2},
                new MedicalInsurance {Name = "Rubesh", PremiumAmount = 180000, AppointmentsCompleted = 1}

            };
            List<LifeInsurance> list1 = new List<LifeInsurance>{
                new LifeInsurance{Name = "Yuvaraj", NomineeName = "Saran", MaturityDate = new DateTime(2050,08,08), PremiumAmount = 5000000},
                new LifeInsurance{Name = "Sathish", NomineeName = "Shankar", MaturityDate = new DateTime(2030,01,02), PremiumAmount = 5000000},
                new LifeInsurance{Name = "Vidyuth", NomineeName = "Gokul", MaturityDate = new DateTime(2038,01,08), PremiumAmount = 8000000},
                new LifeInsurance{Name = "Priya", NomineeName = "Sarath", MaturityDate = new DateTime(2042,01,06), PremiumAmount = 3000000},
                new LifeInsurance{Name = "John", NomineeName = "Som", MaturityDate = new DateTime(2042,05,06), PremiumAmount = 2000000},
                new LifeInsurance{Name = "Divakar", NomineeName = "Ananya", MaturityDate = new DateTime(2042,06,08), PremiumAmount = 6000000},

            };

            var customerId = customerList.Join(insuranceList, b => b.CustomerID, d => d.CustomerID, (b, d) =>
            new
            {
                CustomerName = b.Name,
                AgeOfCustomer = b.Age,
                BloodGroup = b.BloodGroup,
                Status = d.MedicalInsurance
                
            }).Where(bloodgroup => bloodgroup.BloodGroup == "AB+")
              .Where(x => x.AgeOfCustomer <= 60);

            var finaList = customerId.Join(list, y => y.CustomerName, z => z.Name, (y,z) =>
            new
            {
                SelectCustomerName = y.CustomerName,
                medicalInsurance = y.Status,
                Appointments = z.AppointmentsCompleted,
                
            }).Where(w => w.medicalInsurance == true && w.Appointments < 3);

           
            foreach (var val in finaList)
            {
                System.Console.WriteLine(val.SelectCustomerName + " is Eligible For Insurance");
            }


            foreach (string select in customerName)
            {
                System.Console.WriteLine(select + " ");
            }
        }
    }
}
