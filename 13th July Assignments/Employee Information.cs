using System;
using System.Collections;

/*A program should have a class of Employees with property Id and Name .  
 * Make use of indexers to create a collection semantics.  Make use  of HashTable 
 * to store the list of items in a key value pairs.*/

namespace Employee_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable employeeTable = new Hashtable();
            Employee employee1 = new Employee(1, "Richy");
            Employee employee2 = new Employee(2, "Nirmal");
            Employee employee3 = new Employee(3, "Hari");

            employeeTable.Add(employee1.Id, employee1);
            employeeTable.Add(employee2.Id, employee2);
            employeeTable.Add(employee3.Id, employee3);

            foreach (Employee i in employeeTable.Values)
            {
                Console.WriteLine($"Name : {i.Name}\nId : {i.Id}");
            }
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    
    }
}
