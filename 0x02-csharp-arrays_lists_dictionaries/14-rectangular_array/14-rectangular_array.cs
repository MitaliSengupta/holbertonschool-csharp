using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            arr[2, 2] = 1;
            Console.WriteLine("{0} {1} {2} {3} {4}", arr[i, 0], arr[i, 1], arr[i, 2], arr[i, 3], arr[i, 4]);
        }
    }
}

