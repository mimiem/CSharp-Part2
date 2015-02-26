//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//       a)	        |      b)	      |      c)         |	  d)*
//  1	5	9	13  |  1  8  9   16   |  7	11	14	16  |  1   12	11	10
//  2	6	10	14  |  2  7  10	 15   |  4	8	12	15  |  2   13	16	9
//  3	7	11	15  |  3  6	 11	 14   |  2	5	9	13  |  3   14	15	8
//  4	8	12	16  |  4  5	 12	 13   |  1	3	6	10  |  4   5	6	7


using System;

class FillTheMatrix
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
            }
        }

        // Print the matrix on the console
        Console.WriteLine();
        Console.WriteLine("The matrix is as follows:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0}  ", matrix[col, row]); 
            }

            Console.WriteLine();
        }
    }
}

