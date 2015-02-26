//Write a program that sorts an array of strings using the Quick sort algorithm

using System;

class QuickSort
{
    static void QuickSortAlg(int[] arr, int left, int right)
    {
        int originalLeft = left;
        int originalRight = right;
        int pivot = arr[(left + right) / 2];

        while (left < right)
        {
            while (pivot > arr[left])
            {
                left++;
            }
            while (pivot < arr[right])
            {
                right--;
            }
            if (left <= right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }
        if (originalLeft < right)
        {
            QuickSortAlg(arr, originalLeft, right);
        }
        if (left < originalRight)
        {
            QuickSortAlg(arr, left, originalRight);
        }
    }
    static void Main()
    {
        int[] arr = { 5, 1, 9, 4, 10, 3, 7, 2, 6, 8 };
        QuickSortAlg(arr, 0, arr.Length - 1);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

