//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:

//a	    b	    c	    sum
//3	    4	    11	    18
//-2	0	    3	    1
//5.5	4.5	    20.1	30.1


using System;
using System.Threading;
using System.Globalization;



class SumOf3Numbers
{
    static void Main()
    {
        string str;
        double firstNum;
        double secondNum;
        double thirdNum;
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        do
        {
            Console.Write("Please enter a number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out firstNum));

        do
        {
            Console.Write("Please enter a second number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out secondNum));

        do
        {
            Console.Write("Please enter a third number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out thirdNum));

        double sum = firstNum + secondNum + thirdNum;

        Console.WriteLine("The sum of the numbers {0}, {1}, {2} is : {3}", firstNum, secondNum, thirdNum, sum);
    }
}

