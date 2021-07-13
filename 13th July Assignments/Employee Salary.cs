using System;

/*Design an  Employee class with properties EmployeeId, Name, Designation. Have an encapsulated field called Salary. 
 * Expose method called GetSalary() which displays or returns the current salary,  but setting of salary should be done 
 * at the time of hiring (object creation time).  Have an encapsulated method called IncreasePay() , where the salary can 
 * be increased by 10%. The user / client  should be exposed only to a method called Promote() with a boolean value, which 
 * decides the Increase Pay of 10% or not.*/

namespace Employee_Salary
{
    class Employee
    {
        public int Id;
        public string Name;
        public string Designation;
        private int salary;

        public void employeeDetails()
        {
            Console.WriteLine("Enter the Id of the Employee : ");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of the Employee : ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter the Designation of the Employee : ");
            this.Designation = Console.ReadLine();
            Console.WriteLine("Enter the Salary of the Employee : ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public void getInfo()
        {
            Console.WriteLine($"Name of the Employee: {Name}\nId: {Id}\nDesignation: {Designation}");
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public void GetSalary()
        {
            Console.WriteLine("Salary of the Employee : " + salary);
        }
        public void promote(bool condition)
        {
            if (condition == true)
            {
                Console.WriteLine("New Incremented Salary of the Employee : " + IncreasePay());
            }
        }
        public int IncreasePay()
        {
            int new_salary = salary + salary /10;
            return new_salary;
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.employeeDetails();
            employee.getInfo();
            employee.GetSalary();
            employee.promote(true);

        }
    } 
}