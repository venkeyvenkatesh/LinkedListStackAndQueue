using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListSatckAndQueue
{
    class LinkedListQueue
    {
        internal Node head;
        public LinkedListQueue()
        {
            this.head = null;
        }
        internal void Enqueue(int value)
        {
            Node node = new Node(value);
            if (head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;

            }
        }
        internal void Display()
        {
            if (head==null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " \t");
                    temp = temp.next;
                }
            }
        }
    }
}
