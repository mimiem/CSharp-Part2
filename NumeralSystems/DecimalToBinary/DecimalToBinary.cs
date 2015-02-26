//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + DecToBin(number)); 
    }
    static string DecToBin(long decimalNumber)
    {
        string binaryNumber = string.Empty;
        while (decimalNumber > 0) //while there are digits
        {
            var digit = decimalNumber % 2; // take the remainder of the number
            binaryNumber = digit + binaryNumber; // and add it to the binary number
            decimalNumber = decimalNumber / 2; // go for the next digit
        }
       //var numberAsCharArray = binaryNumber.ToCharArray(); |Another way to reverse the number (in the while loop binaryNumber += digit;)
       //Array.Reverse(numberAsCharArray);                   |
       //binaryNumber = new string(numberAsCharArray);       |
        return binaryNumber;
    }
}

