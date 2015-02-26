//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHex
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        long decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int digit = binaryNumber[i] - '0'; 
            int position = binaryNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(2, position);
        }
        string hexNumber = string.Empty;
        while (decimalNumber > 0) 
        {
            long digit = decimalNumber % 16;
            if (digit >= 0 && digit <= 9)
            {
                hexNumber = (char)(digit + '0') + hexNumber;
            }
            else if (digit >= 10 && digit <= 15)
            {
                hexNumber = (char)(digit - 10 + 'A') + hexNumber;
            }
            decimalNumber /= 16;
        }
        Console.WriteLine("Result: " + hexNumber);
    }
}

