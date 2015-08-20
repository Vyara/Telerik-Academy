//Problem 6. Divisible by 7 and 3

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. 
//Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DivisibleBy7And3
{
    static void Main()
    {
        //array with integers
        int[] numbers = new int[100];

        for (int i = 0; i < 100; i++)
        {
            numbers[i] = i;
        }

        //sorted with extention methods and lambda
        var lambdaLocate = numbers.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();
        Console.WriteLine("Numbers that are are divisible by 7 and 3(using lambda and extention methods): ");
        Console.WriteLine(new string('-', 30));
        foreach (var number in lambdaLocate)
        {
            Console.WriteLine(number);
        }

        //sorted with LINQ
        var linqLocate =
            from number in numbers
            where number % 7 == 0 && number % 3 == 0
            select number;
        Console.WriteLine();
        Console.WriteLine("Numbers that are are divisible by 7 and 3(using LINQ): ");
        Console.WriteLine(new string('-', 30));
        foreach (var number in linqLocate)
        {
            Console.WriteLine(number);
        }
    }
}

