/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.*/

using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Minimum: {0}", PrintMin(1, 2, 3, 4, 5));
        Console.WriteLine("Maximum: {0}", PrintMax(1, 2, 3, 4, 5));
        Console.WriteLine("Average: {0}", PrintAverage(1, 2, 3, 4, 5));
        Console.WriteLine("Sum: {0}", PrintSum(1, 2, 3, 4, 5));
        Console.WriteLine("Product: {0}", PrintProduct(1, 2, 3, 4, 5));
    }
    static int PrintMin(params int[] numbers)
    {
        int min = numbers[0];

        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    static int PrintMax(params int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static double PrintAverage(params int[] numbers)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            count++;
        }
        double averageNumber = sum / count;
        return averageNumber;
    }
    static int PrintSum(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static int PrintProduct(params int[] numbers)
    {
        int produkt = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            produkt *= numbers[i];
        }
        return produkt;
    }
}

