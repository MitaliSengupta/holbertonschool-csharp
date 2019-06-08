using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> num = new List<int>();
        for (int i = 0; i < size; i++)
        {
            num.Add(i);
        }
        Console.WriteLine(string.Join(" ", num));
        return num;
    }
}