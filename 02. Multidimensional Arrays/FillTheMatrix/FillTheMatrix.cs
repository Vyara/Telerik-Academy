/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:

a)
2	6	10	14
3	7	11	15
4	8	12	16

b)
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13

c)
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10

d)*
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
*/
using System;



class FillTheMatrix
{
    static void Main()
    {
        string str;
        int n;
        //asks for the length of the array
        do
        {
            Console.Write("Please enter an integer array size n: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out n));

        //creates a 2D matrix of size (n, n) 
        int[,] nSizedMatrix = new int[n, n];
        int rowLength = nSizedMatrix.GetLength(0);
        int colLength = nSizedMatrix.GetLength(1);

        //initializes the matrix based on model a)
        int count = 1;
        for (int col = 0; col < colLength; col++)
        {
            for (int row = 0; row < rowLength; row++)
            {
                nSizedMatrix[row, col] = count;
                count++;
            }
        }

        //prints matrix a)
        Console.WriteLine("Matrix model a), n = {0}: ", n);
        PrintMatrix(nSizedMatrix);

        //initializes the matrix based on model b)
        count = 1;
        for (int col = 0; col < colLength; col++)
        {
            for (int row = 0; row < rowLength; row++)
            {
                if (col % 2 == 0)
                {
                    nSizedMatrix[row, col] = count;
                    count++;
                }
                else
                {
                    nSizedMatrix[rowLength - row - 1, col] = count;
                    count++;
                }

            }
        }
        //prints matrix b)
        Console.WriteLine("Matrix model b), n = {0}: ", n);
        PrintMatrix(nSizedMatrix);

        //initializes the matrix based on model c)
        count = 1;
        for (int row = rowLength - 1; row >= 0; row--)
        {
            int rowCounter = row;
            for (int col = 0; col < rowLength - row; col++)
            {
                nSizedMatrix[rowCounter, col] = count++;
                rowCounter++;

            }
        }

        count = n * n;

        for (int row = 0; row < rowLength - 1; row++)
        {
            int rowCounter = row;

            for (int col = colLength - 1; rowCounter >= 0; col--)
            {
                nSizedMatrix[rowCounter, col] = count--;
                rowCounter--;
            }
        }
        //prints matrix c)
        Console.WriteLine("Matrix model c), n = {0}: ", n);
        PrintMatrix(nSizedMatrix);

        //initializes the matrix based on model d)
        nSizedMatrix = new int[n, n];
        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "down" && (currentRow >= rowLength || nSizedMatrix[currentRow, currentCol] != 0))  
            {
                currentRow--;
                currentCol++;
                direction = "right";
            }
            else if (direction == "right" && (currentCol >= colLength || nSizedMatrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "up";
            }

            else if (direction == "up" && (currentRow < 0 || nSizedMatrix[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol--;
                direction = "left";
            }

            else if (direction == "left" && (currentCol < 0 || nSizedMatrix[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow++;
                direction = "down";
            }
           
            nSizedMatrix[currentRow, currentCol] = i;
            
            if (direction == "down")
            {
                currentRow++;
            }

            else if (direction == "right")
            {
                currentCol++;
            }

            else if (direction == "up")
            {
                currentRow--;
            }

            else if (direction == "left")
            {
                currentCol--;
            }

        }


        //prints matrix d)
        Console.WriteLine("Matrix model d), n = {0}: ", n);
        PrintMatrix(nSizedMatrix);
    }
    //method for printing the matrix
    static void PrintMatrix(int[,] matrix)
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

