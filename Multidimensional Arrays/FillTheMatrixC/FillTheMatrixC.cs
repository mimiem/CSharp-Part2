//        c)
        
//   7	11	14	16 
//   4	8	12	15 
//   2	5	9	13 
//   1	3	6	10 

using System;

class FillTheMatrixC
{
    static void Main()
    {
        // Read the matrix dimensions
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        
        // Allocate the matrix
        int[,] matrix = new int[n, n];
        
        // Enter the matrix elements
        int rows = 0;
        int cols = 0;
        int value = 1;

        for (int i = n - 1; i >= 0; i--) //elements under the diagonal
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = value++;
            }
        }

        for (int j = 1; j < n; j++) // elements above the diagonal
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = value++;
            }
        }

        // Print the matrix on the console
        for (rows = 0; rows < n; rows++)
        {
            for (cols = 0; cols < n; cols++)
            {
                Console.Write("{0, -3}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}

