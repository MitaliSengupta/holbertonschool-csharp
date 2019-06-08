using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach(string item in myDict.Keys)
        {
            int newval = myDict[item] * 2;
            newDict.Add(item, newval);
        }
        return newDict;
    }
}