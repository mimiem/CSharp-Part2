/*Write a program that finds the index of given element in a sorted array 
of integers by using the Binary search algorithm.*/

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Array range is: ");
        int rangeArr = int.Parse(Console.ReadLine());
        int[] arr = new int[rangeArr];
        for (int i = 0; i < rangeArr; i++)
        {
            Console.Write("arr [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("We are searching for: ");
        int value = int.Parse(Console.ReadLine());
        Array.Sort(arr);

        int start = 0;
        int end = arr.Length - 1;

        while ((end - start) > 1)!!!
        {
            int index = start + (end - start) / 2;

            if (arr[index] == value)
            {
                Console.WriteLine("Element {0} is at position [{1}]", value, index);
                return;
            }
            else if (arr[index] > value)
            {
                end = index;
            }
            else if (arr[index] < value)
            {
                start = index;
            }
        }
        Console.WriteLine("Not found!");
    }
}

