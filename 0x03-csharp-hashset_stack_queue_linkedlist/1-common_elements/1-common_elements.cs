using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> final = list1.FindAll(item => list2.Contains(item));
        return(final);
    }
}