﻿namespace LargestConnectedAreaInMatrix
{
    using System;

    /// <summary>
    /// Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.
    /// </summary>
    public class Startup
    {
        private const string Visited = "";
        private const string Empty = "x";
        private static readonly string[,] Matrix =
        {
            { "1", "x", "2", "2", "2", "x" },
            { "x", "x", "x", "2", "4", "x" },
            { "4", "x", "1", "2", "x", "x" },
            { "4", "x", "1", "2", "x", "1" },
            { "4", "x", "1", "x", "x", "x" }
        };

        public static void Main()
        {
            PrintMatrix();

            var bestLength = FindLargestConnectedArea();

            Console.WriteLine("Largest connected area of empty cells: {0}", bestLength != 0 ? string.Format("{0} -> {1} cell(s).", Empty, bestLength) : "There is no best area.");
        }

        private static int FindLargestConnectedArea()
        {
            int bestLength = int.MinValue;

            for (int i = 0; i < Matrix.GetLongLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLongLength(1); j++)
                {
                    var currentLength = 0;

                    FindArea(i, j, ref currentLength);

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                    }
                }
            }

            return bestLength;
        }

        private static void FindArea(int row, int col, ref int currentLength)
        {
            var isNonPassableCell = row < 0 || row >= Matrix.GetLongLength(0) ||
                                    col < 0 || col >= Matrix.GetLongLength(1) ||
                                    Matrix[row, col] != Empty;

            if (isNonPassableCell)
            {
                return;
            }

            currentLength++;
            Matrix[row, col] = Visited;

            FindArea(row, col - 1, ref currentLength);
            FindArea(row, col + 1, ref currentLength);
            FindArea(row - 1, col, ref currentLength);
            FindArea(row + 1, col, ref currentLength);
        }

        private static void PrintMatrix()
        {
            for (int i = 0; i < Matrix.GetLongLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLongLength(1); j++)
                {
                    Console.Write("{0,-3}", Matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
