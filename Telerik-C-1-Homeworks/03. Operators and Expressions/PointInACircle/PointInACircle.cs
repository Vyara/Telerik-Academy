//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

//Examples:

//x	        y	    inside
//0 	    1	    true
//-2	    0	    true
//-1	    2	    false
//1.5	    -1	    true
//-1.5	    -1.5	false
//100	    -30	    false
//0	        0	    true
//0.2	    -0.8	true
//0.9	    -1.93	false
//1	        1.655	true

using System;
using System.Globalization;
using System.Threading;


class PointInACircle
{
    static void Main()
    {
        string str;
        double x;
        double y;
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        
        do
        {
            Console.Write("Please enter a value for x: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out x));


        do
        {
            Console.Write("Please enter a value for y: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!double.TryParse(str, out y));

        //(x - center_x)^2 + (y - center_y)^2 < radius^2
        bool isInside = (Math.Pow(x, 2)) + (Math.Pow(y, 2)) <= (Math.Pow(2, 2));
        Console.WriteLine("Is the point ({0}, {1}) inside the circle?: {2}", x, y, isInside);


    }
}

