//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Linq;

class OrderWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] wordsArray = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(wordsArray);
        Console.WriteLine("Alphabetical order:");
        foreach (var item in wordsArray)
        {
            Console.WriteLine(item);
        }
    }
}

