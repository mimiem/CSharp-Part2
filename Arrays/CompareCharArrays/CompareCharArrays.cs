//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter first char array: ");
        string someString = Console.ReadLine();
        char[] arr1 = someString.ToCharArray();
        Console.Write("Enter second char array: ");
        someString = Console.ReadLine();
        char[] arr2 = someString.ToCharArray();

        if (arr1.Length != arr2.Length)
        {
            Console.WriteLine("Arrays are diffrent");
            return;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                Console.WriteLine("Arrays are different");
                return;
            }
        }
        Console.WriteLine("Arrays are equal");
    }
}

