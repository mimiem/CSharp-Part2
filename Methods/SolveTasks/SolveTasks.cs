/*Write a program that can solve these tasks:
 -Reverses the digits of a number
 -Calculates the average of a sequence of integers
 -Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
 -The decimal number should be non-negative
 -The sequence should not be empty
 -a should not be equal to 0*/

using System;

class SolveTasks
{
    static void ReverseInput()
    {
        Console.Write("Enter some number: ");
        string number = Console.ReadLine();
        if (decimal.Parse(number) > 0)
	    {
		 Console.WriteLine("Reveresed number will be:" + ReverseNumber(number));
	    }
        else
        {
            Console.WriteLine("The decimal number should be non-negative!");
        }
    }

    static decimal ReverseNumber(string number)
    {
        char[] digits = number.ToCharArray();
        Array.Reverse(digits);
        string reversedDigits = new string(digits);
        decimal reversedNumber = decimal.Parse(reversedDigits);
        return reversedNumber;
    }

    static void AverageOfSequence()
    {
        Console.Write("Enter the length of the sequence: ");
        int size = int.Parse(Console.ReadLine());
        if (size<=0)
        {
            Console.WriteLine("Please enter positive integer number");
            return;
        }
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("The average sequence is: {0}", CalculateAverage(arr));
    }

    static double CalculateAverage(int[] sequence)
    {
        int sum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return (double)sum / sequence.Length;
    }

    static void EquationInput()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("\"a\" should not be equal to 0!");
        }
        else
        {
            Console.WriteLine("Equation result is {0}", SolveLinearEquation(a, b));
        }
    }

    static double SolveLinearEquation(double a, double b)
    {
        return (b / a) * (-1);
    }

    static void Main()
    {
        Console.WriteLine("Select a task:");
        Console.WriteLine();
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear equation a * x + b = 0");
        Console.Write("Choose: ");
        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1:
                ReverseInput();
                break;
            case 2:
                AverageOfSequence();
                break;
            case 3:
                EquationInput();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}

