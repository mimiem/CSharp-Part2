/*You are given an array of strings. Write a method that sorts the array by the 
 * length of its elements (the number of characters composing them).*/

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("{[0]} = ");
            array[i] = Console.ReadLine();

        }
        
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length)); //sort 
        
        foreach (string element in array) //print the ordered elements
        {
            Console.WriteLine(element);
        }
        Console.WriteLine();
    }
}

