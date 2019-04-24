using System;

class Program
{
    static void Main(string[] args)
    {
        char i;
        for (i = 'a'; i <= 'z'; i++)
        {
            if (i == 'e' || i == 'q')
            {
                i++;
            }
            Console.Write(i);
        }
    }
}