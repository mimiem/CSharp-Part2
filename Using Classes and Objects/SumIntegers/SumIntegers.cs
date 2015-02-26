/*You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.*/
/*Example:
     input	       output
"43 68 9 23 318"	461 */

using System;
using System.Linq;

class SumIntegers
{
   static void Main()
   {
       Console.WriteLine("Enter a sequence of integers separeted by space:");
       string input = Console.ReadLine();
       
       int result = 0;
       int[] numbers = input.Split(' ').Select((x) => int.Parse(x)).ToArray();
       for (int i = 0; i < numbers.Length; i++)
       {
           result += numbers[i];
       }
       Console.WriteLine("The sum of the numbers is: {0}", result);
       
   }
}

