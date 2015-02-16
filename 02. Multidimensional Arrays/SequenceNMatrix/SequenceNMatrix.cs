/*
Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:
matrix                    result
ha	  fifi	ho	hi        ha, ha, ha
fo	  ha	hi	xx
xxx	  ho	ha	xx

matrix                    result 
s	qq	s                 s, s, s
pp	pp	s
pp	qq	s
 */
using System;



class SequenceNMatrix
{
    static void Main()
    {
        string str;
        int n;
        int m;
        //asks for the length n of the array
        do
        {
            Console.Write("Please enter an integer array size n: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out n));

        //asks for the length m of the array
        do
        {
            Console.Write("Please enter an integer array size m: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out m));

        //creates a 2D string matrix of size (n, n)
        string[,] stringMatrix = new string[n, m];

        //asks for matrix elements and initilizes the matrix
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Please enter string matrix elements:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("element [{0}, {1}]: ", row, col);
                stringMatrix[row, col] = Console.ReadLine();
            }
        }

        //looks for repeating characters as per condition and locates the longest sequence
        string currElement = "";
        int count = 1;
        int bestCount = 0;
        string bestElement = "";
        
        //search rows
        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col < m; col++)
            {
                currElement = stringMatrix[row, col];

                if (stringMatrix[row, col - 1] == currElement)
                {
                    count++;
                }

                else
                {
                    count = 1;
                }

                if (count >= bestCount)
                {
                    bestCount = count;
                    bestElement = currElement;
                }
            }
            count = 1;
        }

        //search columns
        count = 1;
        for (int col = 0; col < m; col++)
        {
            for (int row = 1; row < n; row++)
            {
                currElement = stringMatrix[row, col];

                if (stringMatrix[row - 1, col] == currElement)
                {
                    count++;
                }

                else
                {
                    count = 1;
                }

                if (count >= bestCount)
                {
                    bestCount = count;
                    bestElement = currElement;
                }
            }
            count = 1;
        }

        //search right to left diagonal
        for (int row = 0; row < n; row++)
        {
            for (int col = m - 1; col >= 0; col--)
            {
                count = 1;
                for (int i = row, j = col; i < n - 1 && j > 0; i++, j--)
                {
                    currElement = stringMatrix[i, j];
                    if (currElement == stringMatrix[i + 1, j - 1])
                    {
                        count++;
                    }

                    if (count >= bestCount)
                    {
                        bestCount = count;
                        bestElement = currElement;
                    }
                }
            }
        }

        //search left to right diagonal
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                count = 1;
                for (int i = row, j = col; i < n - 1 && j < m - 1; i++, j++)
                {
                    currElement = stringMatrix[i, j];
                    if (currElement == stringMatrix[i + 1, j + 1])
                    {
                        count++;
                    }

                    if (count >= bestCount)
                    {
                        bestCount = count;
                        bestElement = currElement;
                    }
                }
            }
        }
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Matrix: ");
        PrintMatrix(stringMatrix);
        Console.WriteLine("---------------------------------------");
        Console.Write("Longest sequence: ");
        for (int i = 0; i < bestCount; i++)
        {
            if (i == bestCount - 1)
            {
                Console.Write(bestElement);
            }
            else
            {
                Console.Write(bestElement + ", ");
            }
        }
        Console.WriteLine();
    }

    //method for printing the matrix
    static void PrintMatrix(string[,] matrix)
    {
        Console.WriteLine("---------------------------------------");
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

