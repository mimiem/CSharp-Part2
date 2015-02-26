/*We are given a matrix of strings of size N x M. Sequences in the matrix we define 
 * as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.*/

//    matrix	    |  result	|	 matrix	    | result
//ha  fifi  ho  hi  |ha, ha, ha |   s   qq  s   | s, s, s
//fo	ha	hi	xx  |           |   pp	pp	s   |
//xxx	ho	ha	xx  |           |   pp	qq	s   |


using System;

class SequenceNMatrix
{
    static void Main()
    {
        //Fill the matrix with strings
        Console.Write("Enter rows of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter columns of the matrix: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0}, {1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        //Searching for the longest sequence of equal strings in the matrix
        string someWord = string.Empty;
        int currCount = 1;
        int count = 1;
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currCount = 1;

                if (matrix[row, col] == matrix[row, col + 1]) //on the same line
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                }

                if (currCount > count)
                {
                    count = currCount;
                    someWord = matrix[row, col];
                }
            }
            currCount = 1;
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col]) //on the same column
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                }

                if (currCount > count)
                {
                    count = currCount;
                    someWord = matrix[row, col];
                }
            }

            currCount = 1;
        }
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1]) //diagonal
            {
                currCount++;
            }
            else
            {
                currCount = 1;
            }

            if (currCount > count)
            {
                count = currCount;
                someWord = matrix[row, col];
            }
        }
        //Print the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        //Print the result
        Console.WriteLine("Result: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write("{0}", someWord);
            if (i != count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

