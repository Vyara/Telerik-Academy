//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Threading;
using System.Globalization;


class TheBiggestОfFiveNumbers
{
    static void Main()
    {
        string str;
        double a;
        double b;
        double c;
        double d;
        double e;
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

        do
        {
            Console.Write("Please enter a fourth number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out d));

        do
        {
            Console.Write("Please enter a fifth number: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out e));

        //I'm gonna solve it using 5 if statments, other solution would be just one line: Math.Max(a, Math.Max(Math.Max(b, c), Math.Max(c, d)))

        double? biggest = null;

        if (a > b)
        {
            biggest = a;
        }

        if (b > a)
        {
            biggest = b;
        }

        if (c > biggest)
        {
            biggest = c;
        }

        if (d > biggest)
        {
            biggest = d;
        }

        if (e > biggest)
        {
            biggest = e;
        }

        Console.WriteLine("The biggest number is: {0}", biggest);
    }
}

