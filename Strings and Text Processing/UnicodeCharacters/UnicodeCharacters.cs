//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
//Example:
// input	   output
//  Hi!	 \u0048\u0069\u0021

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        foreach (char ch in text)
        {
            Console.Write("\\u{0:X4}", (int)ch);
        }
        Console.WriteLine();
    }
}

