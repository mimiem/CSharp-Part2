/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
 * smallest from the rest, move it at the second position, etc.*/

using System;

class SelectionSort
{
    static void Main()
    {
        int[] arr = {5, 1, 9, 4, 3, 7, 2, 6, 8};
        for (int i = 0; i < arr.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                arr[i] += arr[min];
                arr[min] = arr[i] - arr[min];
                arr[i] -= arr[min];
            }
        }
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

