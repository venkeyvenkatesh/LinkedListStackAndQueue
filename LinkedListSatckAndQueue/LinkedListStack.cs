using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LinkedListSatckAndQueue
{
    class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (top==null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value + " is pushed to stack");
        }
        internal void Display()
        {
            if (top==null)
            {
                Console.WriteLine("Stack is empty");

            }
            else
            {
                Node temp = this.top;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
