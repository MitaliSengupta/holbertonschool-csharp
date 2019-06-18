using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int itr = 0;
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                itr++;
            }
            return itr;
        }
        catch
        {
            return itr;
        }
    }
}