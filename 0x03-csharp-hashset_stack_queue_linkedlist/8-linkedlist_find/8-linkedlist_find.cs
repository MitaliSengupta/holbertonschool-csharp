using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int idx = 0;
        foreach(int elem in myLList)
        {
            if (elem == value)
            {
                return idx;
            }
            idx++;
        }
        return -1;
    }
}