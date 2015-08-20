//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:

//r	    perimeter	area
//2	    12.57	    12.57
//3.5	21.99	    38.48


using System;
using System.Threading;
using System.Globalization;

class CirclePerimeterAndArea
{
    static void Main()
    {
        string input;
        double r;
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        do
        {
            Console.Write("Please enter a raduis: ");
            input = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(input, out r));

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("The circle with radius {0}, has a perimeter of {1:0.00} and an area of {2:0.00} ", r, perimeter, area);
    }
}
