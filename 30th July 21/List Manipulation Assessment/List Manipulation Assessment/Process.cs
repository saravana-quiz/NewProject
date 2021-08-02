using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace List_Manipulation_Assessment
{
    class Process
    {
        IList<Employee> employeesList = new List<Employee>()
        {
            new Employee() {ID=101, Name = "Jeeva",Experience=8,Salary=10000,Mail="jeeva@test.com" },

            new Employee() {ID=102, Name = "Vanitha",Experience=25,Salary=50000,Mail="jeeva@test.com" },

            new Employee() {ID=103, Name = "Shaj",Experience=20,Salary=16000,Mail="jeeva@test.com" },

            new Employee() {ID=104, Name = "Ebe",Experience=10,Salary=02000,Mail="jeeva@test.com" }
        };

        public void Add(int id,string name,int exprience, double salary,string mail)
        {
            employeesList.Add(new Employee() { ID=id, Name=name, Experience=exprience, Salary=salary, Mail=mail});


        }
        public void Delete(int id, string name, int exprience, double salary, string mail)
        {
            employeesList.Remove(new Employee() { ID = id, Name = name, Experience = exprience, Salary = salary, Mail = mail });

        }
        public void Update(int index, int id, string name, int exprience, double salary, string mail)
        {
            employeesList[index]=(new Employee() { ID = id, Name = name, Experience = exprience, Salary = salary, Mail = mail });

        }

        public void Sort()
        {
            var inAscOrder = employeesList.OrderBy(s => s.ID);
            var inDesOrder = employeesList.OrderByDescending(s => s.ID);

        }
        public void Clear()
        {
            employeesList.Clear();

        }
    }
}
