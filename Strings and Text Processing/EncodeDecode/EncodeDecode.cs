/*Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
 * of the string with the first of the key, the second – with the second, etc. When the last 
 * key character is reached, the next is the first.*/

using System;
using System.Text;

class EncodeDecode
{
    static void Main(string[] args)
    {
        string text = "This is a secret message!";
        Console.WriteLine("Encoded text: {0}", text);
        string key = "cipher";
        char[] decoding = text.ToCharArray();
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < key.Length; j++)
            {
                decoding[i] ^= key[j];
            }
        }
        text = new string(decoding);
        Console.WriteLine("Decoded text: {0}", text);
    }
}

