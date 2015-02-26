/*Write a program to convert from any numeral system of given 
 * base s to any other numeral system of base d (2 ≤ s, d ≤ 16).*/

using System;

class OneSystem
{
    static void Main()
    {
        Console.Write("From numeral system: ");
        int firstSystem = int.Parse(Console.ReadLine());
        Console.Write("To numeral system: ");
        int secondSystem = int.Parse(Console.ReadLine());

        Console.Write("Number to convert: ");
        string number = Console.ReadLine();

        Console.WriteLine("Result: " + DecToBase(BaseToDec(number, firstSystem), secondSystem));
    }
    static long BaseToDec(string number, int numeralSystem)
    {
        long decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] >= '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else
            {
                digit = number[i] - 'A' + 10;
            }
            int position = number.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(numeralSystem, position);
        }
        return decimalNumber;
    }
    static string DecToBase(long decimalNumber, int numeralSystem)
    {
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            long digit = decimalNumber % numeralSystem;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            decimalNumber /= numeralSystem;
        }
        return result;
    }
}

