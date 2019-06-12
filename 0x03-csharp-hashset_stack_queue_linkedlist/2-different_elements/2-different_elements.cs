using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> final = list1.FindAll(item => !list2.Contains(item));
        List<int> fromlist2 = list2.FindAll(item => !list1.Contains(item));
        final.AddRange(fromlist2);
        final.Sort();
        return(final);
    }
}