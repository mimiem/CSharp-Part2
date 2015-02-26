/*Write a program that reads a string from the console and replaces all series of consecutive 
 * identical letters with a single one.
Example:

        input	            output
aaaaabbbbbcdddeeeedssaa	   abcdedsa        */

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa"; //Console.ReadLine();
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] != text[i+1])
            {
                result.Append(text[i]);
            }
        }
        Console.WriteLine(result);
    }
}
