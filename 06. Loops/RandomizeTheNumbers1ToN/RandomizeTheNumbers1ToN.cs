//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:

//n	        randomized numbers 1…n
//3	        2 1 3
//10	    3 4 8 2 6 7 9 1 10 5
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.

using System;
using System.Collections.Generic;



class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        string str;
        int n;

        //аsks for an integer
        do
        {
            Console.Write("Please enter an integer n:  ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out n) || n < 0);

        //creates a list of integers 1...n
        List<int> numbers = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        //prints a randomized list of numbers
        Random randomValue = new Random();
        for (int i = 1; i <= n; i++)
        {
            int random = randomValue.Next(numbers.Count);
            Console.Write(numbers[random] + " ");
            numbers.RemoveAt(random);
        }
        Console.WriteLine();

    }
}

