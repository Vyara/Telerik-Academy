//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;



class MaximalSum
{
    static void Main()
    {
        string str;
        int n;
        int m;
        //asks for the length n of the array
        do
        {
            Console.Write("Please enter an integer array size n(>= 3): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out n) || n < 3);

        //asks for the length m of the array
        do
        {
            Console.Write("Please enter an integer array size m(>= 3): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out m) || m < 3);

        //creates a 2D matrix of size (n, n) 
        int[,] RectangleMatrix = new int[n, m];
        int rowLength = RectangleMatrix.GetLength(0);
        int colLength = RectangleMatrix.GetLength(1);

        //asks for matrix elements and initilizes the matrix
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Please enter matrix elements:");
        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < colLength; col++)
            {
                Console.Write("element [{0}, {1}]: ", row, col);
                RectangleMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        //finds the 3 x 3 area in the matrix, which has the maximal sum
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < rowLength -2; row++)
        {
            for (int col = 0; col < colLength - 2; col++)
            {
                int sum = RectangleMatrix[row, col] 
                    + RectangleMatrix[row, col + 1] 
                    + RectangleMatrix[row, col + 2] 
                    + RectangleMatrix[row + 1, col] 
                    + RectangleMatrix[row + 2, col] 
                    + RectangleMatrix[row + 1, col + 1] 
                    + RectangleMatrix[row + 2, col + 1] 
                    + RectangleMatrix[row + 1, col + 2] 
                    + RectangleMatrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Matrix: ");
        PrintMatrix(RectangleMatrix);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("The 3x3 area with best sum is:");
        Console.WriteLine("{0, -5} {1, -5} {2, -5}", RectangleMatrix[bestRow, bestCol], RectangleMatrix[bestRow, bestCol + 1], RectangleMatrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0, -5} {1, -5} {2, -5}", RectangleMatrix[bestRow + 1, bestCol], RectangleMatrix[bestRow + 1, bestCol + 1], RectangleMatrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0, -5} {1, -5} {2, -5}", RectangleMatrix[bestRow + 2, bestCol], RectangleMatrix[bestRow + 2, bestCol + 1], RectangleMatrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
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

