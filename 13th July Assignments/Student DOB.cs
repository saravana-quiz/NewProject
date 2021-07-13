using System;

/*Write a program which has a class of Student with Id, Name and Date of Birth.  
 * You can set the Date of birth at the time of Admission (object creation),  and have a property which calculates the age.  
 * (use property  get accessors ) and can be accessed from the client / main program. */

namespace Student_DOB
{
    class Program
    {
        private DateTime _DOB;

        public Program(DateTime dateOfBirth)
        {
            this._DOB = dateOfBirth;
        }

        public DateTime DateOFBirth
        {
            get
            {
                return DateOFBirth;
            }
        }
        public int Age
        {
            get
            {
                int dateOfBirth = _DOB.Year;
                int now = DateTime.Now.Year;
                int age = now - dateOfBirth;
                return age;
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        static void Main(string[] args)
        {
            
            DateTime DateofBirth = new DateTime(1999,08,08);
            Program Student = new Program(DateofBirth);
            Student.Id = 8;
            Student.Name = "Richy";
            Console.WriteLine($"Student Age : {Student.Age}\nStudent Name : {Student.Name}\nStudent Id : {Student.Id}");
            


            //Console.WriteLine("Enter your date of birth : Example:yyyy,mm,dd");
            // DateTime born = DateTime.Parse(Console.ReadLine());

            //Program age = new Program(DateofBirth);
            //Console.WriteLine(age.Age);

            /*Console.WriteLine("Enter your date of birth: ");
            DateTime born = DateTime.Parse(Console.ReadLine());
            TimeSpan age = DateTime.Today - born;
            Console.WriteLine("You are {0} years old", Math.Floor(age.Days / 365.255));
            Console.WriteLine("You are {0} days or {1} hours old", age.TotalDays, age.TotalHours);
            Console.ReadKey();*/
        }
    }
}
