using System;

namespace CustomerDetails
{
    class Customer 
    {
        string customerName;
        int customerId;
        public void PlaceOrder()
        {
            Console.WriteLine("Enter the Customer Name: ");
            var customerName = Console.ReadLine();
            Console.WriteLine("Enter the Customer ID: ");
            var customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Order Placed Sucessfully: ");
        }
        public static void GetCustomerTimeZone()
        {
            Console.WriteLine("Timezone: India ");

        }

        static void Main(string[] args)
        {
            
            Customer name = new Customer();
            name.PlaceOrder();
            Customer.GetCustomerTimeZone();
            


        }
    }
}
