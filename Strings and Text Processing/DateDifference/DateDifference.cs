/*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days*/

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();
        DateTime start = DateTime.ParseExact(firstDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(secondDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance between {0} and {1} -> {2} days\n", firstDate, secondDate, Math.Abs((end - start).TotalDays));
    }
}

