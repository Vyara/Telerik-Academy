//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
//Examples:

//n	    min	    max	       random numbers
//5	    0	    1	       1 0 0 1 1
//10	10	    15	       12 14 12 15 10 12 14 13 13 11
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results.

using System;



class RandomNumbersInGivenRange
{
    static void Main()
    {
        string str;
        int n;
        int min;
        int max;

        do
        {
            Console.Write("Please enter an integer n:  ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out n) || n < 0);

        do
        {
            Console.Write("Please enter a min value:  ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out min));

        do
        {
            Console.Write("Please enter a max value:  ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out max) || min >= max);

        Random randomValue = new Random();

        for (int i = 0; i < n; i++)
        {

            Console.Write(randomValue.Next(min, max + 1) + " ");
        }

        Console.WriteLine();
    }
}
