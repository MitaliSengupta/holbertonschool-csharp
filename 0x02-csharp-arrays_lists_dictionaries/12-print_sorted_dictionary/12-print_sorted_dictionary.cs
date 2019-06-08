using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var keyList = myDict.Keys.ToList();
        keyList.Sort();

        foreach (var item in keyList)
        {
            Console.WriteLine("{0}: {1}", item, myDict[item]);
        }
    }
}