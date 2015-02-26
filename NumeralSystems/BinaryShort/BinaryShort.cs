/*Write a program that shows the binary representation of given 16-bit 
 * signed integer number (the C# type short).*/

using System;

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Binary representation");
        Console.Write("Enter integer number from -32000 to +32000: ");
        short number = short.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2);
        Console.WriteLine("Result: " + binary);
    }
}

