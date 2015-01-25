//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

//Examples:

//a	        b	        c	            result
//5	        1	        2	            5 2 1
//-2	    -2	        1	            1 -2 -2
//-2	    4	        3	            4 3 -2
//0	        -2.5	    5	            5 0 -2.5
//-1.1	    -0.5	    -0.1	       -0.1 -0.5 -1.1
//10	    20	        30	            30 20 10
//1	        1	        1	            1 1 1

using System;
using System.Threading;
using System.Globalization;

class SortNumbersWithNestedIfs
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

        if (a > b)
        {
            if (a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0}, {1}, {2}", a, b, c);

                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
        }

        if (a < b)
        {
            if (b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine("{0}, {1}, {2}", b, a, c);

                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
        }

        if (a == b)
        {
            if (a == c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            else if (a > c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
        }

    }
}

