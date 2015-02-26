/*Write a program that finds how many times a sub-string is contained in a given text 
 *(perform case insensitive search).
Example:

The target sub-string is 'in'

The text is as follows: We are living in an yellow submarine. We don't have anything else. 
 * inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9*/

using System;

class SubstringInText
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int index = 0;
        int count = 0;

        while (true)
        {
            int found = text.IndexOf("in", index);
            if (found < 0)
            {
                break;
            }
            index = found + 1;
            count++;
        }
        Console.WriteLine("The sub-string is contained {0} times!", count);

    }
}

