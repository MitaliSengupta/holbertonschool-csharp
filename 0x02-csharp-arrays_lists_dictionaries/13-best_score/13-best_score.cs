using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count <= 0)
        {
            return "None";
        }
        var max = myList.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        return max;
    }
}