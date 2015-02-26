//Write a program that finds the maximal sequence of equal elements in an array.
// Example:
// |           input	               |  result
// |  2, 1, 1, 2, 3, 3, 2, 2, 2, 1	   |  2, 2, 2

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int bestSequence = 1;
        int currSequence = 1;
        int bestStartNumber = 0;

        for (int i = 0; i < n; i++)
        {
           Console.Write("arr[{0}] = ", i);
           arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currSequence++;
            }
            else
            {
                currSequence = 1;
            }
            if (currSequence >= bestSequence)
            {
                bestSequence = currSequence;
                bestStartNumber = arr[i];
            }
        }
        Console.Write("Maximal sequence: ");

        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write("{0} ", bestStartNumber);
        }
        Console.WriteLine();

    }
}

