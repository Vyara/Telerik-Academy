//Problem 5. Maximal area sum

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:

//input	        output
//4 
//2 3 3 4 
//0 2 3 4 
//3 7 1 2 
//4 3 3 2	       17


using System;
using System.IO;



class MaximalAreaSum
{
    static void Main()
    {
        //path of the files
        const string matrix = "../../textfiles/matrix.txt";
        const string result = "../../textfiles/result.txt";
        //reading all lines from the first file
        string[] stringMatrix = File.ReadAllLines(matrix);

        //gets matrix size from first line
        int size = int.Parse(stringMatrix[0]);

        //creates an int matrix of size [size, size]
        int[,] intMatrix = new int[size, size];

        //goes through every string row of the string matrix
        for (int i = 1; i <= size; i++)
        {
            //splits row and assigns it to an array
            string[] currentRow = stringMatrix[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < size; j++)
            {
                //parses current row into the int matrix
                intMatrix[i - 1, j] = int.Parse(currentRow[j]);
            }
        }

        //calculates result
        int maxSum = MaxSum(intMatrix);

        //writes result in a separate file
        using (StreamWriter writer = new StreamWriter(result))
        {
            writer.WriteLine(maxSum);
        }

        //reads files and prints
        ReadFile(matrix, "matrix");
        ReadFile(result, "result");
    }

    //method for calculating max sum
    static int MaxSum(int[,] matrix)
    {

        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }

        }
        return bestSum;
    }

    //method for reading file
    static void ReadFile(string path, string name)
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Reading file " + name + "...");
        using (StreamReader readFile = new StreamReader(path))
        {
            while (!readFile.EndOfStream)
            {
                string line = readFile.ReadLine();

                Console.WriteLine(line);

            }
            Console.WriteLine("End of file " + name + ".");
        }
    }
}
