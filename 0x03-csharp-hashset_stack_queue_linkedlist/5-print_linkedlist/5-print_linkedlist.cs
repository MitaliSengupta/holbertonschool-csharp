using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLlist = new LinkedList<int>();
        if (size < 0)
        {
            return newLlist;
        }
        for (int i = 0; i < size; i++)
        {
            newLlist.AddLast(i);
        }
        foreach(int item in newLlist)
        {
            Console.WriteLine(item);
        }
        return newLlist;
    }
}