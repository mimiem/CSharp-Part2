/*Write a program that reads a rectangular matrix of size N x M and finds 
 * in it the square 3 x 3 that has maximal sum of its elements.*/

using System;

class MaximalSum
{
    static void Main()
    {
        //setting elements value
        Console.Write("Enter rows of the rectangle matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter columns of the rectangle matrix: ");
        int m = int.Parse(Console.ReadLine());
        int[,] rectangle = new int[n, m];
        for (int row = 0; row < rectangle.GetLength(0); row++)
        {
            for (int col = 0; col < rectangle.GetLength(1); col++)
            {
                Console.Write("matrix[{0}, {1}] = ", row, col);
                rectangle[row, col] = int.Parse(Console.ReadLine());
            }
        }
        //Print the matrix
        for (int row = 0; row < rectangle.GetLength(0); row++)
        {
            for (int col = 0; col < rectangle.GetLength(1); col++)
            {
                Console.Write("{0,-3}", rectangle[row, col]);
            }
            Console.WriteLine();
        }
        //Find max sum
        int widnt = 3;
        int height = 3;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < rectangle.GetLength(0) - height + 1; row++) //set the area of search
        {
            for (int col = 0; col < rectangle.GetLength(1) - widnt + 1; col++)
            {
                int sum = 0;
                for (int platformRow = row; platformRow < row + height; platformRow++)
                {
                    for (int platformCol = 0; platformCol < col + widnt; platformCol++)
                    {
                        sum += rectangle[platformRow, platformCol];
                    }
                }
                if (sum>bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        //Print the result on the console
        for (int platformRow = bestRow; platformRow < bestRow + height; platformRow++)
        {
            for (int platformCol = bestCol; platformCol < bestCol + widnt; platformCol++)
            {
                Console.Write("{0,-3}", rectangle[platformRow,platformCol]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}

