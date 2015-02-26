/*Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
 * and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day 
 * of week in Bulgarian.*/

using System;
using System.Globalization;

class DateBulgarian
{
    static void Main()
    {
        string text = "23.02.2015 17:30:15";
        DateTime date = DateTime.Parse(text).AddHours(6).AddMinutes(30);       
        Console.WriteLine("{0} {1}", date.ToString("dddd"), date);
    }
}
