using System;

class Program
{
    static void Main(string[] args)
    {
        string comma = "";
        for(int i = 0; i <= 9; i++)
        {
            for (int j = i + 1; j <= 9; j ++)
            {

                Console.Write("{0}{1:d}{2:d}",comma, i, j);
                comma = ", ";
            }
        }
        Console.WriteLine();
    }
}
