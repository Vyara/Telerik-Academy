//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;



class GetLargestNumber
{
    static void Main()
    {
        string str;
        long firstNumber;
        long secondNumber;
        long thirdNumber;

        //asks user to enter 3 integers(using long)
        do
        {
            Console.Write("Please enter an integer: ");
            str = Console.ReadLine();

        } while (!long.TryParse(str, out firstNumber));

        Console.WriteLine("-------------------------------------------");
        do
        {
            Console.Write("Please enter a second integer: ");
            str = Console.ReadLine();

        } while (!long.TryParse(str, out secondNumber));

        Console.WriteLine("-------------------------------------------");
        do
        {
            Console.Write("Please enter a third integer: ");
            str = Console.ReadLine();

        } while (!long.TryParse(str, out thirdNumber));

        //uses method GetMax() again to find the largest number of the 3
        long MaxNumber = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);

        //prtins the result to the console
        Console.WriteLine("-------------------------------------------");
        Console.Write("The biggest number of {0}, {1}, {2}, is: {3}.", firstNumber, secondNumber, thirdNumber, MaxNumber);
        Console.WriteLine();
    }

    //method for returning the larger of two integers
    static long GetMax(long firstNumber, long secondNumber)
    {
        long MaxNumber = Math.Max(firstNumber, secondNumber);
        return MaxNumber;
    }
}

