//Write a program that finds the sequence of maximal sum in given array
//Example:

//              input	             |   result
// 2, 3, -6, -1, 2, -1, 6, 4, -8, 8	 | 2, -1, 6, 4

//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSum
{
    static void Main()
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxSum = numbers[0]; 
        int currentSum = numbers[0];
        int start = 0;
        int startTemp = 0;
        int end = 0;
        
        for (int i = 1; i < numbers.Length; i++)
        {
            currentSum += numbers[i];
            if (currentSum < numbers[i])
            {
                currentSum = numbers[i];
                startTemp = i;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }
        }

        Console.Write("The sequence with maximal sum is: ");
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine();
    }
}

