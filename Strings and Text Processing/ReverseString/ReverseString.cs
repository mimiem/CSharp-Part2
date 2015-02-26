//Write a program that reads a string, reverses it and prints the result at the console.
/*Example:

input	output
sample	elpmas*/

using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        string reversed = ReverseText(input);
        Console.WriteLine("Reversed string: {0}", reversed);
    }
    public static string ReverseText(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }
        return sb.ToString();
    }
}

