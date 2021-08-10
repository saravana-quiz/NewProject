using System;

namespace Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            DLinkedList node1 = new DLinkedList(2);
            DLinkedList node3 = node1.InsertNext(4);
            DLinkedList node2 = node3.InsertPrev(6);
            DLinkedList node5 = node3.InsertNext(8);
            DLinkedList node4 = node5.InsertPrev(9);
            node1.TraverseFront();
            node5.TraverseBack();
        }
        class DLinkedList
        {
            private int data;
            private DLinkedList next;
            private DLinkedList prev;

            public DLinkedList()
            {
                data = 0;
                next = null;
                prev = null;
            }
            public DLinkedList(int value)
            {
                data = value;
                next = null;
                prev = null;
            }
            public DLinkedList InsertNext(int value)
            {
                DLinkedList node = new DLinkedList(value);

                if (this.next == null)
                {
                    node.prev = this;
                    node.next = null; 
                    this.next = node;
                }
                else
                {
                    DLinkedList temp = this.next;
                    node.prev = this;
                    node.next = temp;
                    this.next = node;
                    temp.prev = node;
                }
                return node;
            }
            public DLinkedList InsertPrev(int value)
            {
                DLinkedList node = new DLinkedList(value);

                if (this.prev == null)
                {
                    node.prev = null; 
                    node.next = this;
                    this.prev = node;
                }
                else
                {
                    DLinkedList temp = this.prev;
                    node.prev = temp;
                    node.next = this;
                    this.prev = node;
                    temp.next = node;
                }
                return node;
            }
            public void TraverseFront()
            {
                TraverseFront(this);
            }
            public void TraverseFront(DLinkedList node)
            {
                if (node == null)
                {
                    node = this;
                }
                System.Console.WriteLine("\nTraversing in Forward Direction");

                while (node != null)
                {
                    System.Console.WriteLine(node.data);
                    node = node.next;
                }
            }
            public void TraverseBack()
            {
                TraverseBack(this);
            }
            public void TraverseBack(DLinkedList node)
            {
                if (node == null)
                {
                    node = this;
                }              
                System.Console.WriteLine("\nTraversing in Backward Direction");

                while (node != null)
                {
                    System.Console.WriteLine(node.data);
                    node = node.prev;
                }
            }           
        }
    }
}
