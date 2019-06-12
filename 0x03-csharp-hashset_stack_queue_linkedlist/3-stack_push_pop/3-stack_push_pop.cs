using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count <= 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            string peek = aStack.Peek();
            Console.WriteLine("Top item: {0}", peek);
        }
        bool contains = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, contains);
        if (contains)
        {
            while((aStack.Peek()!= search || aStack.Peek() == search) && aStack.Contains(search))
            {
                aStack.Pop();
            }
        }
        aStack.Push(newItem);   
        return (aStack);
    }
}