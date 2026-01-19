using System;
using System.Collections.Generic;
using System.Text;

namespace online_exam_review_system
{
    internal class Stack
    {

        private int[] arr;
        private int top;

        public Stack(int n)
        {
            arr = new int[n];
            top = -1;
        }

        public Stack()
        {
            arr = new int[10];
            top = -1;
        }
        
        public void Push(int data)
        {
            if(top == arr.Length - 1)
            {
                Console.WriteLine("Stack is Overflow");
                return;
            }
            arr[++top] = data;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("There is no element");
                return -1;
            }
            return arr [ top-- ];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}
