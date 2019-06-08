using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int row = myMatrix.GetLength(0);
        int col = myMatrix.GetLength(1);
        int[,] newMatrix = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                newMatrix[i,j] = (int)Math.Pow(myMatrix[i, j], 2);
            }
        }
        return newMatrix;
    }
}
