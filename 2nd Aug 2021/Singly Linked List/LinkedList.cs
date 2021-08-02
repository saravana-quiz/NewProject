using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    class LinkedList
    {
        public int Count;

        private Node head;

        private Node current;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtFirst(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }

        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("The List is Empty");
            }
        }
        /*public void RemoveFromLast()
        {
            
        }*/

        public void PrintAllNodes()
        {
            Node currentNode = head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;

                Console.Write($"{currentNode.Value} =>");
            }
            Console.WriteLine("Null");
        }

    }


}
