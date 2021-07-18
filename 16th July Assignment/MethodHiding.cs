using System;

/*1. Method Hiding 
 
Create a Base Class with a method with the name WriteNum and display an integer. 
Create another virtual method WriteStr and display some string.
Create a Derived class and create a hidden method by name WriteNum and override the method WriteStr. 
Create Objects -
 -objectA  of type base class 
- objectB of type  base class but downcasted to the derived class 
- objectC of type derived class 
Display the methods from all 3 objects*/

namespace Method_Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base Class Objects :");
            User details = new User();
            details.WriteStr();
            details.WriteNum();

            Console.WriteLine("Derived Class Objects :");
            NewUser newDetails = new NewUser();
            newDetails.WriteStr();
            newDetails.WriteNum();

            //odownCastedObject of type  base class but downcasted to the derived class
            Console.WriteLine("Object of type Base class but Downcasted to the Derived class");
            var downCastedObject = (User)details;
            downCastedObject.WriteStr();
            downCastedObject.WriteNum();
        }
    }
    class User
    {
        public virtual void WriteStr()  //virtual keyword is used to create virtual methods
        {
            string Name = "BATMAN";
            Console.WriteLine("Name :"+Name);
        }
        public void WriteNum()
        {

            int age = 16;
            Console.WriteLine("Age :"+age);
        }
    }
    class NewUser : User
    {
        public override void WriteStr()
        {
            string NewName = "RICHY";
            Console.WriteLine("New User Name :"+NewName);
        }
        public new void WriteNum()
        {
            int newAge = 18;
            Console.WriteLine("New User Age :"+newAge);
        }
    }
}
