using System;

namespace Stack_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack elements = new Stack();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Push an Element in the stack.");
                Console.WriteLine("2. Pop last Element in the stack.");
                Console.WriteLine("3. Get the Top Element in the stack.");
                Console.WriteLine("4. Display all Elements in the stack.");
                Console.WriteLine("5. Exit the application");
                Console.WriteLine("Enter your Action : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an element to push :");
                        elements.PushElement(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Last Element of the stack is removed.");
                        break;
                    case 3:
                        Console.WriteLine("Top Element of the Stack is :"+ elements.PeekElement());
                        break;
                    case 4:
                        elements.DisplayStackElements();               
                        break;
                    case 5:
                        System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();


            }
        }
    }
}
