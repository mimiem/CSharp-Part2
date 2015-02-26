/*Write a program that reverses the words in given sentence.
Example:
                input	                 |                   output
C# is not C++, not PHP and not Delphi!	 |   Delphi not and PHP, not C++ not is C#!      */

using System;
using System.Collections.Generic;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine("Before: {0}", text);
        string[] words = text.Split(new char[] {' ', '!'}, StringSplitOptions.RemoveEmptyEntries);
        List<int> commas = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(","))
            {
                commas.Add(i);
                words[i] = words[i].Substring(0, words[i].Length - 1);
            }
        }
        Array.Reverse(words);
        char exMark = text[text.Length - 1];

        if (commas.Count > 0)
        {
            for (int i = 0; i < commas.Count; i++)
            {
                words[commas[i]] += ',';
            }
        }
        Console.WriteLine("After: {0}", String.Join(" ", words) + exMark);
        
    }
}

