using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int idx = 0;
        foreach(int item in myLList)
        {
            if(idx == n)
            {
                return item;
            }
            idx++;
        }
        return 0;
    
    }
}