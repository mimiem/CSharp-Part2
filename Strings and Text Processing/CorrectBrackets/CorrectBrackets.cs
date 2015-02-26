/*Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).*/

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter a expression with brackets: ");
        string input = Console.ReadLine();
        int countBrackets = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                countBrackets++;
            }
            if (input[i] == ')')
            {
                countBrackets--;
            }
        }
        if (countBrackets == 0)
        {
            Console.WriteLine("The expression is correct!");
        }
        else
        {
            Console.WriteLine("The expression is incorrect!");
        }
    }
}

