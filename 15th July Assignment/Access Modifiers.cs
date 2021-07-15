using System;
using System.Reflection;

/*2.Explore all the available access modifiers for both Properties and Methods,  
    create a program to demonstrate the use of   Protected, Internal , Private and Public.*/

namespace Access_Modifiers
{
    class Car
    {
        public string brandName, result;
        public string BrandName
        {
            get
            {
                return result;
            }
            set
            {
                brandName = value;
            }
        }

        /*A public member can access the class, field, constructor or method,
        regardless of where the accessing code is located. The accessing code
        can be in a different class and different package*/
        public void GetBrandName()
        {
            Model();
            result ="MiniCooper";
            
        }
        //Private Method can't be accessed in other class
        private static void Model()
        {
            Console.WriteLine("Model: Mini_CountryMan");
        }

        /*Protected method can only be invoked from within
        the implementation of a class or its subclasses*/
        protected static void RoadTax()
        {
            Console.WriteLine("Road Tax : 18000 rupees"); ;
        }

        //internal can be accessed from many other classes within the same assembly
        internal void Price()
        {
            Console.WriteLine("Price : 420000 lakhs"); ;
        }
    }
    class Customer : Car
    {
        public void GetRoadTax()
        {
            RoadTax();
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".....Car Details.....");
            Car details = new Car();
            details.GetBrandName();
            Console.WriteLine("Brand Name:" + details.BrandName);
            details.Price();
            Customer obj2 = new Customer();
            obj2.GetRoadTax();
        }
    }
}
