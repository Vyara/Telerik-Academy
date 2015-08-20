//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:

//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720


using System;



class CalculateNBangOverKBang
{
    static void Main()
    {
        string str;
        int firstNumber;
        int secondNumber;
        long factorialFirst = 1;
        long factorialSecond = 1;
        // do while loops to make sure the entered numbers are valid(not included in the solution itself)
        do
        {
            Console.Write("Please enter a valid integer n: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out firstNumber) || firstNumber > 100 );

        do
        {
            Console.Write("Please enter a valid integer k: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out secondNumber) || secondNumber < 1 || secondNumber > firstNumber);

        //solution with only one loop
        for (int i = 1; i <= firstNumber; i++)
        {
            if (i <= secondNumber)
            {
                factorialSecond *= i;
            }
            factorialFirst *= i;

        }

        Console.WriteLine(@" n! / k! = {0}", (double)factorialFirst / factorialSecond);
    }
}

