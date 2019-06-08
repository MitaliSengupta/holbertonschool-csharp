using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();


        Console.WriteLine("Best Score: {0}", Dictionary.BestScore(myDict));
    }
}