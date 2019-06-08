using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[]{0, 1, 2, 3};
        jagged[1] = new int[]{0, 1, 2, 3, 4, 5, 6};
        jagged[2] = new int[]{0, 1};

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j]);
                if (j != jagged[i].Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}