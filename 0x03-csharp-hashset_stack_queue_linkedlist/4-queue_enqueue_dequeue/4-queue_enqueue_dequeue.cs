using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count <= 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        bool contain = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"{0}\": {1}",search, contain);
        if (contain)
        {
            while((aQueue.Peek() != search || aQueue.Peek() == search) && aQueue.Contains(search))
            {
                aQueue.Dequeue();
            }
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}