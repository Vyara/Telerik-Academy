//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.
//Examples:

//n	x	S
//3	2	2.75000
//4	3	2.07407
//5	-4	0.75781

using System;



class CalculateSum
{
    static void Main()
    {
        string str;
        int firstNumber;
        int secondNumber;
        long factorial = 1;
        double sum = 1;

        do
        {
            Console.Write("Please enter an integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out firstNumber));

        do
        {
            Console.Write("Please enter another integer: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out secondNumber));

        for (int i = 1; i <= firstNumber; i++)
        {
            factorial *= i;
            sum += (factorial / Math.Pow(secondNumber, i));
            
        }

        Console.WriteLine("sum = {0:F5}", sum);
    }
}

