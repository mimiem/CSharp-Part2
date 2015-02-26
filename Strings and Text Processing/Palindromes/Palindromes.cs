//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text;

class Palindromes
{
    static void Main()
    {
        string text = "ABBA, dog, lamal, exe, lol, txt, lame";
        string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("The palindromes are:");
        foreach (var word in words)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            if (word == sb.ToString())
            {
                Console.WriteLine(word);
            }
        }
    }
}

