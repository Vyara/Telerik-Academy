//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:

//n	    k	n! / (k! * (n-k)!)
//3	    2	3
//4	    2	6
//10	6	210
//52	5	2598960


using System;
using System.Numerics;



class CalculateFactorialFunction
{
    static void Main()
    {
        string str;
        int firstNumber;
        int secondNumber;
        BigInteger factorialFirst = 1;
        BigInteger factorialSecond = 1;
        BigInteger factorialSubstract = 1;

        // do while loops to make sure the entered numbers are valid(not included in the solution itself)
        do
        {
            Console.Write("Please enter a valid integer n: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out firstNumber) || firstNumber > 100);

        do
        {
            Console.Write("Please enter a valid integer k: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out secondNumber) || secondNumber < 1 || secondNumber > firstNumber);

        //solution with only two loops

        for (int i = 1; i <= firstNumber; i++)
        {
            if (i <= secondNumber)
            {
                factorialSecond *= i;
            }
            factorialFirst *= i;

        }
        int firstMinusSecond = firstNumber - secondNumber;

        for (int i = 1; i <= firstMinusSecond; i++)
        {
            factorialSubstract *= i;
        }
        
        BigInteger result = factorialFirst / (factorialSecond * factorialSubstract);

        Console.WriteLine(@"n! / (k! * (n-k)!) = {0}", result);
    }
}

