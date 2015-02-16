/*
 Problem 7.* Largest area in matrix

Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
Example:
matrix                      result
1	3	2	2	2	4        13
3	3	3	2	4	4
4	3	1	2	3	3
4	3	1	3	3	1
4	3	3	3	1	1
*/

using System;



class LargestAreaInMatrix
{
    static int[,] elements;
    static int currentLength = 0;
    static int currentElement = 0;
    static int bestLength = 0;
    static int bestElement = 0;


    static void Main()
    {
        //example matrix
        elements = new[,]
        {
            {1,	3,	2,	2,	2,	4 },   
            {3,	3,	3,	2,	4,	4 },  //replace with your own
            {4,	3,	1,	2,	3,	3 },
            {4,	3,	1,	3,	3,	1 },
            {4,	3,	3,	3,	1,	1 },
        };
        //int rows = elements.GetLength(0);
        //int cols = elements.GetLength(1);

        PrintMatrix(elements);
        BestArea(elements);


    }
    //method for getting the area
    static void GetArea(int row, int col)
    {
        if (row < 0 || row >= elements.GetLength(0) || col < 0 || col >= elements.GetLength(1) || elements[row, col] == 0) return;

        if (elements[row, col] == currentElement)
        {
            elements[row, col] = 0;
            currentLength++;

            GetArea(row - 1, col);
            GetArea(row + 1, col);
            GetArea(row, col - 1);
            GetArea(row, col + 1);
        }
    }

    //method for finding the best area
    static void BestArea(int[,] matrix)
    {
        bestLength = bestElement = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentElement = matrix[row, col];
                currentLength = 0;

                GetArea(row, col);

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestElement = currentElement;
                }
            }
        }
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Most occuring element is {0}, occurs {1} times. ", bestElement, bestLength);
    }

    //method for printing the matrix
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, -5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


