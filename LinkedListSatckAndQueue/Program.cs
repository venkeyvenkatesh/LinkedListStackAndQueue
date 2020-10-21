using System;

namespace LinkedListSatckAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Demo program on Linked List stack and Queue");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
        }
    }
}
