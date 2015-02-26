//     b)	   
// 1  8  9   16
// 2  7  10	 15
// 3  6	 11	 14
// 4  5	 12	 13

using System;

class FillTheMatrixB
{
    static void Main()
    {
        // Read the matrix dimensions
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        // Allocate the matrix
        int[,] matrix = new int[n, n];

        // Enter the matrix elements
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                int element = int.Parse(Console.ReadLine());
                matrix[row, col] = element;
                if (col % 2 == 0)
                {
                    matrix[row, col] = row + col * n + 1;
                }
                else
                {
                    matrix[row, col] = col * n + n - row;
                }
            }
        }
        
        // Print the matrix on the console
        Console.WriteLine();
        Console.WriteLine("The matrix is as follows:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0}  ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}

