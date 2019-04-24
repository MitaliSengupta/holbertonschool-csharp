using System;

class Program
{
    static void Main(string[] args)
    {
        int i;
        for (i = 0; i <= 98; i++)
        {
            Console.WriteLine("{0:D} = 0x{0:x}", i);
        }
    }
}