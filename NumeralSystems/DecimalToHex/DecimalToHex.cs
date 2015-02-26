//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHex
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + DecToHex(number));
    }
    static string DecToHex(long decimalNumber)
    {
        string hexNumber = string.Empty;
        while (decimalNumber > 0) 
        {
            long digit = decimalNumber % 16;
            if (digit >= 0 && digit <= 9) //if the remainder is between 0 and 9
            {
                hexNumber = (char)(digit + '0') + hexNumber; //add to hex number
            }
            else if (digit >= 10 && digit <= 15) //if the remainder is between 10 and 15
            {
                hexNumber = (char)(digit - 10 + 'A') + hexNumber; // add to hex number
            }
            decimalNumber /= 16; //go for the next digit
        }
        return hexNumber;
    }
}

