//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//input	            output
//"43 68 9 23 318"	461


using System;
using System.Linq;



class SumIntegers
{
    static void Main()
    {
        Console.Write("Please enter a sequence of integer numbers, separated by space: ");
        string str = Console.ReadLine();
        int[] numbers = str.Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("-----------------------------------------");
        Console.Write("The sum of the numbers is {0}.", numbers.Sum());
        Console.WriteLine();
    }
}

