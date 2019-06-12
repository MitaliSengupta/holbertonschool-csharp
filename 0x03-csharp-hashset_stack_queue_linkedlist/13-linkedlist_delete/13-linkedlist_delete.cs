using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> curr = myLList.First;
        if (index < 0 || myLList.Count <= index)
        {
            return;
        }
        for(int i = 0; i < index; i++)
        {
            curr = curr.Next;
        }
        myLList.Remove(curr);
    }
}