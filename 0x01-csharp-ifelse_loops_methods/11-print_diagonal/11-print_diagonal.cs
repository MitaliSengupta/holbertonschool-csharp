using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        string slash = "\\";
        if (length < 1)
        {
            Console.WriteLine();
        }
        else
        {        
            for (int i = 0; i < length; i ++)
            {
            Console.Write(new string(' ', i));
            Console.WriteLine("{0}", slash);
            }
            Console.WriteLine();
        }       
    }
}