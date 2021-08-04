using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_DS
{
    class Stack : StackMethods
    {
        private int _StackSize;
        public int top;
        object[] stackElements;
        public int CustomSize 
        {
            get { return _StackSize; }
            set { _StackSize = value; }
        }

        public Stack()
        {
            CustomSize = 10;
            stackElements = new object[CustomSize];
            top = -1;
        }
        public Stack(int size)
        {
            CustomSize = size;
            stackElements = new object[CustomSize];
            top = -1;
        }

        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            else
            return false;
        }
        public void PushElement(object element)
        {
            if (top == (_StackSize - 1))
            {
                Console.WriteLine("Stack Memory Full");
            }
            else
            {
                stackElements[++top] = element;
                Console.WriteLine("Element is pushed into Stack Memory");
            }
        }

        public object PopElement()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return "No Elemnts";
            }
            else
            {
                return stackElements[top--];
            }
        }

        public object PeekElement()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return "No Elemnts";
            }
            else
            {
                return stackElements[top];
            }
        }

        public void DisplayStackElements()
        {
            Console.WriteLine($"Elements in the Stack are...");

            for (int i = top; i > -1; i--)
            {             
                Console.WriteLine(stackElements[i]);
            }
        }
    }
}
