//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
//Example 1:

//input 	output
//3         min = 1 
//2         max = 5 
//5         sum = 8 
//1	        avg = 2.67


//Example 2:

//input	    output
//2         min = -1 
//-1        max = 4 
//4	        sum = 3 
//          avg = 1.50


using System;



class MinMaxSumAndAverage
{
    static void Main()
    {
        string str;
        int numbersCount;

        do
        {
            Console.Write("Please enter a count of numbers n:  ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out numbersCount) || numbersCount < 0);

        long sum = new long();
        int min = new int();
        int max = new int();

        for (int i = 0; i < numbersCount; i++)
        {
            Console.Write("Please enter integer number {0}: ", i + 1);
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (i == 0)
            {
                min = number;
                max = number;
            }

            if (number >= max)
            {
                max = number;
            }
            else if (number <= min)
            {
                min = number;
            }

        }
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", (double)sum / numbersCount);
    }
}
