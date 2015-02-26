/*Write a program that reads a string from the console and lists all different 
 * words in the string along with information how many times each word is found.*/

using System;
using System.Collections.Generic;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        Console.Write("Enter words: ");
        string text = Console.ReadLine();
        var dict = new Dictionary<string, int>();
        string[] words = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            if (!dict.ContainsKey(words[i]))
            {
                dict.Add(words[i], 1);
            }
            else if (dict.ContainsKey(words[i]))
            {
                dict[words[i]] += 1;
            }
        }
        Console.WriteLine();
        foreach (var word in dict)
        {
            Console.WriteLine("{0} -> {1} times", word.Key, word.Value);
        }
        Console.WriteLine();
    }
}

