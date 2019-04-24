using System;

class Program
{
    static void Main(string[] args)
    {
        string comma = "";
        for(int i = 0; i <= 99; i++)
        {
            Console.Write("{0}{1:D2}", comma, i);
            comma = ", ";
        }
        Console.WriteLine();
    }
}
