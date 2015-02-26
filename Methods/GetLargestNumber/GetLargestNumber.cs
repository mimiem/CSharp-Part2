//Write a method GetMax() with two parameters that returns the larger of two integers.
/*Write a program that reads 3 integers from the console and prints the largest 
 * of them using the method GetMax().*/

using System;

class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = firstNumber;
        if (secondNumber > firstNumber)
        {
            return secondNumber;
        }
        else
        {
            return firstNumber;
        }
    }
    
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("the biggest number is {0}", GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
    }
}
