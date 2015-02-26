/*Write a program that reads from the console a string of maximum 20 characters. 
 *If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.*/

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder(20);
        Console.Write("Enter a string with max 20 characters: ");
        string text = Console.ReadLine();
        if (text.Length>20)
        {
            Console.WriteLine("Incorect input!");
        }
        else
        {
            sb.Append(text);
            for (int i = 0; i < 20 - text.Length; i++)
            {
                sb.Append('*');
            }
        }
        Console.WriteLine(sb);
    }
}

