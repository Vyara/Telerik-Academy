//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Examples:

//a	        b	    h	    area
//5	        7	    12	    72
//2	        1	    33	    49.5
//8.5	    4.3	    2.7	    17.28
//100	    200	    300	    45000
//0.222	    0.333	0.555	0.1540125


using System;
using System.Threading;



class Trapezoids
{
    static void Main()
    {
        string str;
        double a;
        double b;
        double h;
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        do
        {
            Console.Write("Please enter a value for a: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out a));

        do
        {
            Console.Write("Please enter a value for b: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out b));

        do
        {
            Console.Write("Please enter a value for h: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out h));

        double area = ((a + b) / 2) * h;

        Console.WriteLine("The area of a trapezoid with sides {0}, {1} and height {2}, is: {3}", a, b, h, area);
    }
}

