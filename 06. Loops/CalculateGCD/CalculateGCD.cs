//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
//Examples:

//a	    b	    GCD(a, b)
//3	    2	    1
//60	40	    20
//5	    -15	        5


using System;



class CalculateGCD
{
    static void Main()
    {
        string str;
        int a;
        int b;

        do
        {
            Console.Write("Please enter an integer a: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out a));

        do
        {
            Console.Write("Please enter an integer b: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out b));

        int minValue = Math.Abs((Math.Min(a, b)));
        int result = 1;
        int count = 1;

        while (count <= minValue)
        {
            if (a % count == 0 && b % count == 0)
            {
                result = count;
            }
            count++;
        }

        Console.WriteLine("GCD({0}, {1}) = {2}",a, b, result);
    }
}

