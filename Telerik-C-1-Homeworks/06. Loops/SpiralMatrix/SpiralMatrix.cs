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
        Console.Write("Please enter the size of matrix: ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int row = 0;
        int col = 0;
        string direction = "down";
        int bottom = size - 1;
        int top = 0;
        int left = 1;
        int right = size - 1;

        matrix[0, 0] = 1;
        for (int count = 2; count <= size * size; count++)
        {
            switch (direction)
            {
                case "down":
                    row++;
                    matrix[row, col] = count;
                    if (row == bottom)
                    {
                        direction = "right";
                        bottom--;
                    }
                    break;

                case "right":
                    col++;
                    matrix[row, col] = count;
                    if (col == right)
                    {
                        direction = "up";
                        right--;
                    }
                    break;

                case "up":
                    row--;
                    matrix[row, col] = count;
                    if (row == top)
                    {
                        direction = "left";
                        top++;
                    }
                    break;

                case "left":
                    col--;
                    matrix[row, col] = count;
                    if (col == left)
                    {
                        direction = "down";
                        left++;
                    }
                    break;
            }
        }

        for (row = 0; row < size; row++)
        {
            for (col = 0; col < size; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

