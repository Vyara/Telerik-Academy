//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;


class TriangleSurface
{
    static void Main()
    {
        //creates a menu for use with options to chose from
        int choice;
        string str;
        Console.WriteLine("Calculate triangle surface by: ");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("1) a side and an altitude to it.");
        Console.WriteLine("2) three sides.");
        Console.WriteLine("3) two sides and an angle between them.");
        Console.WriteLine("-------------------------------------------");
        do
        {
            Console.Write("Please enter 1, 2 or 3: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out choice) || (choice != 1 && choice != 2 && choice != 3));

        //asks for user input based on choice
        Console.WriteLine("-------------------------------------------");
        if (choice == 1)
        {
            decimal side;
            decimal altitude;
            do
            {
                Console.Write("Please enter a side: ");
                str = Console.ReadLine();

            } while (!decimal.TryParse(str, out side) || side < 0);

            do
            {
                Console.Write("Please enter an altitude: ");
                str = Console.ReadLine();

            } while (!decimal.TryParse(str, out altitude) || altitude < 0);

            //uses CalculateBySideAndAltitude() to get result and prints it 
            decimal result = CalculateBySideAndAltitude(side, altitude);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Sufrace of triangle with side {0} and altitude {1} = {2:F2}", side, altitude, result);
        }

        if (choice == 2)
        {
            double a;
            double b;
            double c;
            do
            {
                Console.Write("Please enter side a: ");
                str = Console.ReadLine();

            } while (!double.TryParse(str, out a) || a < 0);

            do
            {
                Console.Write("Please enter side b: ");
                str = Console.ReadLine();

            } while (!double.TryParse(str, out b) || b < 0);


            do
            {
                Console.Write("Please enter side c: ");
                str = Console.ReadLine();

            } while (!double.TryParse(str, out c) || c < 0);

            //uses CalculateByThreeSides() to get result and prints it 
            double result = CalculateByThreeSides(a, b, c);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Sufrace of triangle with sides {0}, {1} and {2} = {3:F2}", a, b, c, result);
        }

        if (choice == 3)
        {
            double a;
            double b;
            double angle;
            do
            {
                Console.Write("Please enter side a: ");
                str = Console.ReadLine();

            } while (!double.TryParse(str, out a) || a < 0);

            do
            {
                Console.Write("Please enter side b: ");
                str = Console.ReadLine();

            } while (!double.TryParse(str, out b) || b < 0);


            do
            {
                Console.Write("Please enter angle in degrees: ");
                str = Console.ReadLine();

            } while (!double.TryParse(str, out angle) || angle < 0);

            //uses CalculateByTwoSidesAndAngle() to get result and prints it 
            double result = CalculateByTwoSidesAndAngle(a, b, angle);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Sufrace of triangle with sides {0}, {1} and angle {2} degrees = {3:F2}", a, b, angle, result);
        }
    }
    //calculates surface of triangle by side and an altitude
    static decimal CalculateBySideAndAltitude(decimal side, decimal altitude)
    {
        decimal area = (side * altitude) / (decimal)2.0;
        return area;
    }

    //calculates surface of triangle by three sides
    static double CalculateByThreeSides(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2.0;
        double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        return area;
    }

    //calculates surface of triangle by two sides and an angle between them
    static double CalculateByTwoSidesAndAngle(double sideA, double sideB, double angle)
    {
        angle = angle * Math.PI / 180.0;
        double sinus = Math.Sin(angle);
        double area = (sideA * sideB * sinus) / 2.0;
        return area;
    }

}

