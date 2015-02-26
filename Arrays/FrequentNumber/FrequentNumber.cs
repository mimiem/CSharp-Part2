//Write a program that finds the most frequent number in an array.
//Example:
//              input	                 |   result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	 | 4 (5 times)


using System;

class FrequentNumber
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int maxCount = int.MinValue;
        int currentCount = 1;
        int number = 0;
        Array.Sort(arr);
        for (int index = 1; index < arr.Length; index++)
        {
            if (arr[index] == arr[index - 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                number = arr[index];
            }
        }
        if (arr.Length == 1)
        {
            maxCount = 1;
            number = arr[0];
        }
        Console.WriteLine("The most frequent number is {0} ({1} times)", number, maxCount);
    }
}

