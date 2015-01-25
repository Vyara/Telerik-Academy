//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

//a	    b	    c	    result
//5	    2	    2	    +
//-2    -2	    1	    +
//-2	 4	    3	    -
//0	    -2.5	4	    0
//-1	-0.5	-5.1	-

using System;
using System.Threading;
using System.Globalization;



class MultiplicationSign
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

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }

        else if (Math.Sign(a) == Math.Sign(b) && Math.Sign(a) == Math.Sign(c) && Math.Sign(b) == Math.Sign(c))
        {
            Console.WriteLine(Math.Sign(a) == 1 ? "+" : "-");
        }

        else if ((a > 0 && b > 0) || (a > 0 && c > 0) || (b > 0 && c > 0) )
        {
            Console.WriteLine("-");
        }

        else
        {
            Console.WriteLine("+");
        }

    }
}

