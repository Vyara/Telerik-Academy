//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//Examples:

//weight	weight on the Moon
//86	    14.62
//74.6	    12.682
//53.7	    9.129


using System;
using System.Globalization;


class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Please enter a person's weight in kilograms: ");
        double earthWeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double moonWeight = earthWeight * 0.17;
        Console.WriteLine("A person weighing {0} kg on Earth, will weigh {1} kg on the Moon.", earthWeight, moonWeight);
    }
}

