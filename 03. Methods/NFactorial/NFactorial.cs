//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;


class NFactorial
{
    static void Main()
    {
        //creating and initializing an array of the numbers from 1 to 100
        int[] arrayOfHundred = new int[100];

        for (int i = 0; i < arrayOfHundred.Length; i++)
        {
            arrayOfHundred[i] = i + 1;
        }

        //finding factorials of integers 1 to 100 by using FactorialOfN()
        BigInteger[] result = FactorialOfN(arrayOfHundred);

        //printing the results using PrintFactorials()
        PrintFactorials(arrayOfHundred, result);
    }


    //method for calculating factorial of a number
    static BigInteger Factorial(int number)
    {
        BigInteger factorial = number;

        while (number > 1)
        {
            factorial *= number - 1;
            number--;
        }

        return factorial;
    }

    //method for calculating factorials of numbers withing an array
    static BigInteger[] FactorialOfN(int[] array)
    {
        BigInteger[] factorialArray = new BigInteger[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            factorialArray[i] = Factorial(array[i]);
        }

        return factorialArray;
    }

    //method for printing
    static void PrintFactorials(int[] array, BigInteger[] factorials)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("{0}! = {1}", array[i], factorials[i]);
            Console.WriteLine("------------------------------------");
        }
        Console.WriteLine();
    }

}

