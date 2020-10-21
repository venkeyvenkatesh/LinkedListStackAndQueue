using System;

namespace LinkedListSatckAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Demo program on Linked List stack and Queue");


            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);
            queue.Display();

            queue.Dequeue();
            queue.Display();

            queue.Dequeue();
            queue.Display();
            queue.Dequeue();
            queue.Display();
        }
    }
}
