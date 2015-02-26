//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        string maxKsum = string.Empty;
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        for (int i = arr.Length - 1; i > arr.Length - 1 - k; i--)
        {
            maxKsum += arr[i] + " ";
        }
        Console.WriteLine(maxKsum);
    }
}

