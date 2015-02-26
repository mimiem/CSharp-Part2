//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Result: " + BinToDec(number));
    }
    static long BinToDec(string binaryNumber)
    {
        long decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int digit = binaryNumber[i] - '0'; // '0' - '0' = 0; '1' - '0' = 1..., otherwise will give the numbers from ascii table
            //int digit = binaryNumber[i] == '1' ? 1 : 0; ---> another way
            int position = binaryNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(2, position);
        }
        return decimalNumber;
    }
}

