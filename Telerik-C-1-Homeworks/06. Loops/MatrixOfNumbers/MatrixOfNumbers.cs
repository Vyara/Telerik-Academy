//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7


using System;



class MatrixOfNumbers
{
    static void Main()
    {
        int number;
        string str;
        do
        {
            Console.Write("Please enter a valid integer n: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out number) || number > 20 || number < 1);

        int count = 0;

        for (int i = 1; i <= number; i++)
        {

            for (int j = i; j <= number + count; j++)
            {
                Console.Write(j.ToString().PadRight(3));
            }

            Console.WriteLine();

            count++;
        }
    }
}

