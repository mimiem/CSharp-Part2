//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Main()  
    {
        Console.Write("Enter the length of the array: ");
        int arrLength = int.Parse(Console.ReadLine());
        Console.Write("Number that we count in the array: ");
        int someNumber = int.Parse(Console.ReadLine());
        
        int[] arr = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine("The number {0} appers {1} times in the given array.", someNumber, NumberFrequencyInArray(arr, someNumber));
    }
    static int NumberFrequencyInArray(int[] arr, int someNumber)
    {
        int count = 0;

        foreach (var number in arr)
        {
            if (number == someNumber)
            {
                count++;
            }
        }
        return count;
    }
}

