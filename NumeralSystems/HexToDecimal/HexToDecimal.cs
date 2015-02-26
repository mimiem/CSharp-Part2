//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Result: " + HexToDec(number));
    }
    static long HexToDec(string hex)
    {
        long decimalNumber = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            int digit = 0;
            if (hex[i] >= '0' && hex[i] <= '9')
            {
                digit = hex[i] - '0';
            }
            else if (hex[i] >= 'A' && hex[i] <= 'F')
            {
                digit = hex[i] - 'A' + 10; //'A' - 'A' + 10; 'B' - 'A' + 10
            }
            int position = hex.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(16, position);
        }
        return decimalNumber;
    }
}

