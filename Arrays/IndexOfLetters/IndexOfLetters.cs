//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];

       for (int i = 0; i < 26; i++)
       {
           alphabet[i] = (char)('a' + i);
       }

        Console.Write("Enter some word: ");
        string someWord = Console.ReadLine();
        someWord = someWord.ToLower();

        foreach (char letter in someWord)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    Console.WriteLine("{0} --> {1}", letter, i);
                }
            }
        }
    }
}

