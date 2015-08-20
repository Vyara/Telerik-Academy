//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

//Examples:

//a	        b	        c	    result
//5	        1	        2	    5 2 1
//-2	    -2	        1	    1 -2 -2
//-2	    4	        3	    4 3 -2
//0	        -2.5	    5	    5 0 -2.5
//-1.1	    -0.5	    -0.1	-0.1 -0.5 -1.1
//10	    20	        30	    30 20 10
//1	        1	        1	    1 1 1

using System;
using System.Threading;
using System.Globalization;


class DigitAsWord
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Please enter a digit(0-9): ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "0": Console.WriteLine("zero");
                break;
            case "1": Console.WriteLine("one");
                break;
            case "2": Console.WriteLine("two");
                break;
            case "3": Console.WriteLine("three");
                break;
            case "4": Console.WriteLine("four");
                break;
            case "5": Console.WriteLine("five");
                break;
            case "6": Console.WriteLine("six");
                break;
            case "7": Console.WriteLine("seven");
                break;
            case "8": Console.WriteLine("eight");
                break;
            case "9": Console.WriteLine("nine");
                break;

            default: Console.WriteLine("not a digit");
                break;
        }
    }
}

