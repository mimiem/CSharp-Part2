/*Write a method that checks if the element at given position in given array 
 * of integers is larger than its two neighbours (when such exist)*/

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the position: ");
        int position = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Number on the position [{0}] is larger than its neigbours? {1}", position, CheckNumberIsLarger(arr, position, arrLength));
        
    }
    static bool CheckNumberIsLarger(int[]arr, int position, int arrLength)
    {
        if (position <= 0 || position >= arrLength - 1)
        {
            return false;

        }
        else if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

