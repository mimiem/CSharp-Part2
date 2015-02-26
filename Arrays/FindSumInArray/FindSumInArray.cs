//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//      array	     |  S  |result
//4, 3, 1, 4, 2, 5, 8| 11  |4, 2, 5

using System;

class FindSumInArray
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int s = 11;
        int sum = 0;
        bool solution = false;
        for (int i = 0; i < arr.Length; i++)
        {            
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    solution = true;
                    Console.Write("The sequence is: ");
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("{0} ",arr[print]);
                    }
                    Console.WriteLine();
                }
            }
            sum = 0;
        }
        if (!solution)
        {
            Console.WriteLine("Тhere is no such а sequnce with sum = {0}!", s);
        }
    }
}

