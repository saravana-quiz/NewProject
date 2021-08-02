using System;

namespace Singly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing the Empty List");
            LinkedList linkedlist = new LinkedList();
            linkedlist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Printing the List with Data");
            linkedlist.AddAtLast(2);
            linkedlist.AddAtLast(8);
            linkedlist.AddAtLast(16);
            linkedlist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Printing the List with Data added at First Index");
            linkedlist.AddAtFirst(32);
            linkedlist.PrintAllNodes();
            Console.WriteLine();

            Console.WriteLine("Printing the List with Data removed at First Index");
            linkedlist.RemoveFromStart();
            linkedlist.PrintAllNodes();
            Console.ReadKey();
        }
    }
}
