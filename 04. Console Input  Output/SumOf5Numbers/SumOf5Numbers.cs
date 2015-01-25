//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers	                sum
//1 2 3 4 5	                15
//10 10 10 10 10	        50
//1.5 3.14 8.2 -1 0	        11.84


using System;
using System.Threading;
using System.Globalization;


class SumOf5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double sum = 0;
        double parsedNum = 0;
        Console.Write("Please enter 5 numbers, separated by a space: ");
        string[] inputNumbers = Console.ReadLine().Split(' ');

        for (int i = 0; i < 5; i++)
        {
            parsedNum = double.Parse(inputNumbers[i]);
            sum += parsedNum;
        }

        Console.WriteLine("The sum of the given numbers is: {0}", sum);
    }
}

