//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
//Examples:

//a	b	result
//5	2	2 5
//3	4	3 4
//5.5	4.5	4.5 5.5

using System;
using System.Threading;
using System.Globalization;


    class ExchangeIfGreater
    {
        static void Main()
        {
            string str;
            double a;
            double b;
            double temp = 0;
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

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine(a + " " + b);
        }
    }

