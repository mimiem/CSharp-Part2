//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        string dayOfTheWeek = DateTime.Now.DayOfWeek.ToString();
        Console.WriteLine("Today is " + dayOfTheWeek);
    }
}

