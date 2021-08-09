using System;

namespace Queue_Data_Structure
{
    class Program
    {
        class Queue
        {
            Node head;
            class Node
            {
                public int Value;
                public Node next;

                public Node()
                {
                    next = null;
                }
            }

            public void Enqueue(int val)
            {
                if (head == null)
                {
                    Node temp = new Node();
                    temp.Value = val;
                    head = temp;
                    return;
                }

                Node tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                Node newElement = new Node();
                newElement.Value = val;
                tempNode.next = newElement;
            }
            public void Dequeue()
            {
                if (head != null)
                {
                    if (head.next != null)
                    {
                        head = head.next;
                        return;
                    }
                    head = null;
                }
            }
        }
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

        }
    }
}
