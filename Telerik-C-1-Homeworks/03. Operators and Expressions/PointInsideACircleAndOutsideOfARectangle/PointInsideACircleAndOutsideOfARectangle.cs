//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
//Examples:

//x	    y	    inside K & outside of R
//1	    2	        yes
//2.5	2	        no
//0	    1	        no
//2.5	1	        no
//2	    0	        no
//4	    0	        no
//2.5	1.5	        no
//2	    1.5	        yes
//1	    2.5	        yes
//-100	-100	    no

using System;
using System.Threading;



class PointInsideACircleAndOutsideOfARectangle
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
        bool isIncircle = (Math.Pow((x - 1), 2)) + (Math.Pow((y - 1), 2)) <= (Math.Pow(1.5, 2));
        
        //(y > top || y < top - height || x < left || x > left + width)
        bool isOutRec = (y > 1 || y < -1 || x < -1 || x > 5);
        
        bool inAndout = isIncircle && isOutRec;
        Console.WriteLine("Is the point ({0}, {1}) inside the circle and outside the rectangle?: {2}", x, y, inAndout);
    }
}

