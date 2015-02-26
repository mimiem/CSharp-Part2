/*Write a method that returns the index of the first element in array that is 
 *larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.*/

using System;

class FirstLargerThanNeighbours
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
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (CheckNumberIsLarger(arr, i, arrLength))
            {
                Console.WriteLine("First larger than neighbours number is on index [{0}]", i);
                count++;
                return;
            }
        }
        if (count == 0)
        {
            Console.WriteLine(-1);
        }
       
    }
    static bool CheckNumberIsLarger(int[] arr, int position, int arrLength)
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

