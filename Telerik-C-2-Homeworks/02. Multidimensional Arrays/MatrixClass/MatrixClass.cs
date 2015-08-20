//Problem 6.* Matrix class

//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;


class MatrixClass
{
    //class Matrix
    public class Matrix
    {
        private int[,] matrix;

        //set a constructor
        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
        }

        //creates a Rows property to display row length
        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }

        }

        //creates a Cols property to display column length
        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        //defines an indexer for accessing the matrix content
        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        //overloads the operator for adding
        public static Matrix operator +(Matrix first, Matrix second)
        {
            //EXception handling if not equal number of rows and cols
            if (first.Rows != second.Rows && second.Cols != second.Cols)
            {
                throw new ArgumentException("Invalid dimensions!");
            }
            Matrix result = new Matrix(first.Rows, first.Cols);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Cols; col++)
                {
                    result[row, col] = first[row, col] + second[row, col];
                }
            }
            return result;
        }

        //overloads the operator for substracting
        public static Matrix operator -(Matrix first, Matrix second)
        {
            //EXception handling if not equal number of rows and cols
            if (first.Rows != second.Rows && second.Cols != second.Cols)
            {
                throw new ArgumentException("Invalid dimensions!");
            }
            Matrix result = new Matrix(first.Rows, first.Cols);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Cols; col++)
                {
                    result[row, col] = first[row, col] - second[row, col];
                }
            }
            return result;
        }

        //overloads the operator for multiplying
        public static Matrix operator *(Matrix first, Matrix second)
        {
            //EXception handling if first matrix cols != second matrix rows
            if (first.Cols != second.Rows)
            {
                throw new ArgumentException("Invalid dimensions!");
            }
            Matrix result = new Matrix(first.Rows, second.Cols);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Cols; col++)
                {
                    result[row, col] = 0;
                    for (int i = 0; i < first.Cols; i++)
                    {
                        result[row, col] += first[row, i] * second[i, col];
                    }
                }
            }
            return result;
        }

        //overrides the ToString() method
        public override string ToString()
        {
            string result = null;
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result +=  matrix[row, col] + "    ";
                }
                result += Environment.NewLine;
            }
            return result;
        }
    }

    static void Main()
    {
        string str;
        int firstRows;
        int firstCols;
        //asks for first matrix row length
        do
        {
            Console.Write("Please enter first matrix row length(> 0): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out firstRows) || firstRows <= 0);

        //asks for first matrix col length
        do
        {
            Console.Write("Please enter first matrix column length(> 0): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out firstCols) || firstCols <= 0);

        //creates a Matrix object of size (firstRows, firstCols) 
        Matrix firstMatrix = new Matrix(firstRows, firstCols);


        //asks for matrix elements and initilizes the matrix
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Please enter matrix elements:");
        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                Console.Write("element [{0}, {1}]: ", row, col);
                firstMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int secondRows;
        int secondCols;
        //asks for second matrix row length
        do
        {
            Console.Write("Please enter second matrix row length(> 0): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out secondRows) || secondRows <= 0);

        //asks for second matrix col length
        do
        {
            Console.Write("Please enter second matrix column length> 0): ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out secondCols) || secondCols <= 0);

        //creates a Matrix object of size (firstRows, firstCols) 
        Matrix secondMatrix = new Matrix(secondRows, secondCols);


        //asks for matrix elements and initilizes the matrix
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Please enter matrix elements:");
        for (int row = 0; row < secondMatrix.Rows; row++)
        {
            for (int col = 0; col < secondMatrix.Cols; col++)
            {
                Console.Write("element [{0}, {1}]: ", row, col);
                secondMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        //prints first matrix
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("First matrix: ");
        Console.WriteLine(firstMatrix.ToString());

        //prints second matrix
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Second matrix: ");
        Console.WriteLine(secondMatrix.ToString());

        //adds first and second matrices if possible and prints the result
        Matrix sum = firstMatrix + secondMatrix;
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Sum of the two matrices(must be equal sized): ");
        Console.WriteLine(sum.ToString());

        //substracts first and second matrices if possible and prints the result
        Matrix difference = firstMatrix - secondMatrix;
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Difference of the two matrices(must be equal sized): ");
        Console.WriteLine(difference.ToString());

        //multiplies first and second matrices if possible and prints the result
        Matrix product = firstMatrix * secondMatrix;
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Product of the two matrices(columns of the first must be equal to rows of the second): ");
        Console.WriteLine(product.ToString());

    }

}

