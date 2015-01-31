//Problem 19.** Spiral Matrix

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7


using System;


class SpiralMatrix
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

        int[,] matrix = new int[number, number];

        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            matrix[i, 0] = i;
            Console.Write(matrix[i, 0]);
            for (int j = i; j <= number + count; j++)
            {
                matrix[0, j] = j;
                Console.Write(matrix[0, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        count++;
    }
}

