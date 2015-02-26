//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        IsLeapYear(year);
    }
        
    static int IsLeapYear(int year)
    {
        if (year >= 1 && year <= 9999)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is NOT a leap year.", year);
            }
        }
        else
        {
            Console.WriteLine("Invalid Year!");
        }
        return year;
    }
}

