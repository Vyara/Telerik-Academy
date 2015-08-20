//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.
//Examples:

//a	    b	    c	    biggest
//5	    2	    2	    5
//-2	-2	    1	    1
//-2	4	    3	    4
//0	    -2.5	5	    5
//-0.1	-0.5	-1.1	-0.1

using System;
using System.Threading;
using System.Globalization;


class TheBiggestOf3Numbers
{
    static void Main()
    {
        string str;
        double a;
        double b;
        double c;
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        do
        {
            Console.Write("Please enter a number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out a));


        do
        {
            Console.Write("Please enter a second number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out b));

        do
        {
            Console.Write("Please enter a third number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out c));

        Console.WriteLine("The biggest of the numbers {0}, {1}, and {2} is: {3}", a, b, c, Math.Max(a, Math.Max(b, c)));
    }
}

