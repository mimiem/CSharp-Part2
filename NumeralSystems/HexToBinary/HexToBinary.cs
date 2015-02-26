//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine();
        long decimalNumber = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            int digit = 0;
            if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
            {
                digit = hexNumber[i] - '0';
            }
            else if (hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
            {
                digit = hexNumber[i] - 'A' + 10; 
            }
            int position = hexNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(16, position);
        }
        string binaryNumber = string.Empty;
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 2;
            binaryNumber = digit + binaryNumber;
            decimalNumber = decimalNumber / 2;
        }
        Console.WriteLine("Result: " + binaryNumber);
    }
}

