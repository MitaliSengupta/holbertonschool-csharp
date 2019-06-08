using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> final = new List<bool>();
        if (myList.Count == 0)
        {
            return final;
        }
        foreach(int item in myList)
        {
            if (item % 2 == 0)
            {
                final.Add(true);
            }
            else
            {
                final.Add(false);
            }
        }
        return final;
    }
}