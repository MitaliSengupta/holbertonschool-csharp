using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
       HashSet<int> unique = new HashSet<int>(myList);
       int sum = 0;
       foreach(int item in unique)
       {
           sum += item;
       }
        return(sum);
    }
}