//Write a method that reverses the digits of given decimal number.
//Example: | input	|output |
//         |  256	| 652   |

using System;
using System.Globalization;
using System.Threading;

class ReverseNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter some decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number: {0}", ReversingNumber(number));

    }
    static decimal ReversingNumber(decimal number)
    {
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);
        return decimal.Parse(new string(digits));
    }
}

