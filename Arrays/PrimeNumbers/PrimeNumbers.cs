//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter number between 1 to 10 000 000: ");
        int number = int.Parse(Console.ReadLine());
        bool[] arr = new bool[number];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = true;
        }
        for (int i = 2; i < Math.Sqrt(arr.Length); i++)
        {
            if (arr[i])
            {
                for (int j = i * i; j < arr.Length; j = j + i)
                {
                    arr[j] = false;
                }
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

