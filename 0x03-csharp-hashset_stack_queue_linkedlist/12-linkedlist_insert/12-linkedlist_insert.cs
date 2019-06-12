using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> curr = myLList.First;
        while(curr != null)
        {
            if (curr.Value > n)
            {
                return myLList.AddBefore(curr, n);
            }
            curr = curr.Next;
        }
        return myLList.AddLast(n);
    }
}