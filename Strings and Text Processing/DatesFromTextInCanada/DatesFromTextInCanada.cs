//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Globalization;

class DatesFromTextInCanada
{
    static void Main()
    {
        string txt = "Today is 23.02.2015 and I feel terrible. Maybe at 06.03.2015 I will be worse.";
        string[] words = txt.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        List<DateTime> dates = new List<DateTime>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i][words[i].Length - 1] == '.')
            {
                words[i] = words[i].Substring(0, words[i].Length - 1);
            }

            DateTime date;
            if (DateTime.TryParseExact(words[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                dates.Add(date);
            }
        }

        foreach (var item in dates)
        {
            Console.WriteLine(item.ToString(new CultureInfo("en-CA")));
        }
    }
}

