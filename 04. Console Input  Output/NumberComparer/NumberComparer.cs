/*
 Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
Examples:

a	b	greater
5	6	6
10	5	10
0	0	0
-5	-2	-2
1.5	1.6	1.6
*/

using System;
using System.Threading;
using System.Globalization;



class NumberComparer
{
    static void Main()
    {
        string str;
        decimal firstNum;
        decimal secondNum;
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        do
        {
            Console.Write("Please enter a number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!decimal.TryParse(str, out firstNum));

        do
        {
            Console.Write("Please enter a second number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!decimal.TryParse(str, out secondNum));

        Console.WriteLine("The greater number of {0} and {1} is {2}", firstNum, secondNum, Math.Max(firstNum, secondNum));
    }
}

