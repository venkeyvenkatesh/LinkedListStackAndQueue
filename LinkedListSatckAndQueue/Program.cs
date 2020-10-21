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
            stack.Peek();
            stack.Pop();
            stack.Display();
            if (stack.isEmpty())
            {
                Console.WriteLine("\nStack is empty");
            }
            else
            {
                Console.WriteLine("\nStack is not empty");
            }
        }
    }
}
