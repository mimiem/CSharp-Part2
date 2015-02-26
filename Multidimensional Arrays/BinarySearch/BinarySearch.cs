/*Write a program, that reads from the console an array of N integers and 
 * an integer K, sorts the array and using the method Array.BinSearch() finds 
 * the largest number in the array which is ≤ K.*/

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr [{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers); //sorts the array

        while (Array.BinarySearch(numbers, k) < 0) //searching for K or closest to K
        {
            k--;
        }
        Console.WriteLine("K or close to K is {0} ", k); //prints the result
    }
}

