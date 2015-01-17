//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.



using System;
using System.Globalization;




class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter a floating point number: ");
        double floatNumber1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Enter a second floating point number: ");
        double floatNumber2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double eps = 0.000001;
        bool areEqual = Math.Abs(floatNumber1 - floatNumber2) < eps;

        Console.WriteLine("Are the two numbers equal to eachother?: {0}", areEqual);


    }
}

