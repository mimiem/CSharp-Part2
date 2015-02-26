//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter arrays range: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr1[{0}]= ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr2[{0}]= ", i);
            arr2[i] = int.Parse(Console.ReadLine());
        }

        bool equal = true;
        for (int i = 0; i < n; i++)
        {
            if (arr1[i] != arr2[i])
            {
                equal = false; 
                break;
            }
        }
        Console.WriteLine();
        
        if (equal)
        {
            Console.WriteLine("Arrays are equal.");
        }
        else
        {
            Console.WriteLine("Arrays are different.");
        }
    }
}

