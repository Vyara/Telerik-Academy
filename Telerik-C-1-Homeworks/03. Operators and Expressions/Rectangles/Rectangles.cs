//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:

//width	height	perimeter	area
//3	        4	    14	    12
//2.5	    3	    11	    7.5
//5	        5	    20	    25


using System;
using System.Globalization;


class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter a rectangle's width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Please enter a rectangle's height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double perimeter = (2 * width) + (2 * height);
        Console.WriteLine("The perimeter of a rectangle with width {0} and height {1}, is {2}.", width, height, perimeter);
        double area = width * height;
        Console.WriteLine("The area of a rectangle with width {0} and height {1}, is {2}.", width, height, area);

    }
}

