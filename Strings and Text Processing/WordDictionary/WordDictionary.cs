/*A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:
input	    output
.NET	    platform for applications from Microsoft
 CLR	    managed execution environment for .NET
namespace	hierarchical organization of classes      */

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter a word (.NET, CLR, namespace): ");
        string word = Console.ReadLine();

        var dictionary = new Dictionary<string, string>();

        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine(dictionary[word]);
        }
        else
        {
            Console.WriteLine("The dictionary is very small!");
        }
    }
}

