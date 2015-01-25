//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Examples:

//a	    b	    c	        roots
//2	    5	    -3	        x1=-3; x2=0.5
//-1	3	    0	        x1=3; x2=0
//-0.5	4	    -8	        x1=x2=4
//5	    2	    8	        no real roots


using System;
using System.Threading;
using System.Globalization;



class QuadraticEquation
{
    static void Main()
    {
        string str;
        double a;
        double b;
        double c;
        double firstRoot;
        double secondRoot;

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

        double discriminant = (b * b) - (4 * a * c);

        if (discriminant >= 0)
        {
            firstRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
            secondRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);

            if (firstRoot == secondRoot)
            {
                Console.WriteLine("The equation {0}x^2 + {1}x + {2} = 0 has one root: x = {3}. ", a, b, c, firstRoot);
            }
            else
            {
                Console.WriteLine("The equation {0}x^2 + {1}x + {2} = 0 has two roots: x1 = {3} and x2 = {4}. ", a, b, c, firstRoot, secondRoot);
            }
        }

        else
        {
            Console.WriteLine("The equation {0}x^2 + {1}x + {2} = 0 has no real roots. ", a, b, c);
        }

    }
}

