/*Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
 * preliminary as array.*/

using System;
using System.Linq;

class Workdays
{
    static void Main(string[] args)
    {
        DateTime dateNow = DateTime.Now;
        Console.Write("Enter a date in format dd.MM.yyyy:");
        int[] futureDateInput = Console.ReadLine().Split('.')
                                                  .Select(int.Parse)
                                                  .ToArray();
        DateTime futureDate = new DateTime(futureDateInput[2], futureDateInput[1], futureDateInput[0]);
        Console.WriteLine("Workdays between {0:dd.MM.yyyy} and {1:dd.MM.yyyy} is {2}", dateNow, futureDate, CheckWorkingDays(dateNow, futureDate));
    }

    static readonly DateTime[] holidays = 
    {
        new DateTime(2015, 1, 1), new DateTime(2015, 2, 3),
        new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
        new DateTime(2015, 4, 11), new DateTime(2015, 4, 12),
        new DateTime(2015, 4, 13), new DateTime(2015, 5, 1),
        new DateTime(2015, 5, 6), new DateTime(2015, 9, 21),
        new DateTime(2015, 9, 22), new DateTime(2015, 12, 24),
        new DateTime(2015, 12, 25), new DateTime(2015, 12, 26),
        new DateTime(2015, 12, 31)
    };
    private static int CheckWorkingDays(DateTime dateNow, DateTime futureDate)
    {
        int count = 0;
        if (dateNow > futureDate)
        {
            DateTime swap = dateNow;
            dateNow = futureDate;
            futureDate = swap;
        }
        while (dateNow <= futureDate)
        {
            if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday && dateNow.DayOfWeek != DayOfWeek.Sunday)
            {
                count++;
            }
            dateNow = dateNow.AddDays(1);
        }
        return count;
    }
}

/*1 януари 2015 – Нова година. 
2, 3 март – Ден на Освобождението на България от османско робство. 
10, 11, 12, 13 април – Великден – християнската религия отбелязва Възкресение Христово. 
1 май – Ден на труда и на международната работническа солидарност. 
6 май – Гергьовден, Ден на храбростта и Българската армия 
21 и 22 септември – Ден на независимостта на България 
24, 25, 26 декември – Коледа
31 декември и 1 януари 2016*/