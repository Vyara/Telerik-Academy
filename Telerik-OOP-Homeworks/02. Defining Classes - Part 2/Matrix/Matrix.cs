//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
//Implement an indexer this[row, col] to access the inner matrix cells.
//Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//Throw an exception when the operation cannot be performed.
//Implement the true operator (check for non-zero elements).

namespace Matrix
{
    using System;
    using System.Text;

    class Matrix<T> where T : IComparable
    {
        //fields
        private T[,] matrix;
        private int rows;
        private int cols;

        //constructors
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
            this.Rows = rows;
            this.Cols = cols;
        }

        //indexer
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return this.matrix[row, col];
            }

            set
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                this.matrix[row, col] = value;
            }
        }

        //properties
        public int Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Matrix row count should be greater than zero.");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Matrix column count should be greater than zero.");
                }

                this.cols = value;
            }
        }

        //methods
        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new InvalidOperationException("Both matrices must be of equal sizes.");
            }

            Matrix<T> sum = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    sum[row, col] = (dynamic)a[row, col] + b[row, col];
                }
            }

            return sum;
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new InvalidOperationException("Both matrices must be of equal sizes.");
            }

            Matrix<T> difference = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    difference[row, col] = (dynamic)a[row, col] - b[row, col];
                }
            }

            return difference;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Rows)
            {
                throw new ArgumentException("Invalid dimensions!");
            }

            Matrix<T> product = new Matrix<T>(a.Rows, b.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < b.Cols; col++)
                {
                    product[row, col] = (dynamic)0;

                    for (int i = 0; i < a.Cols; i++)
                    {
                        product[row, col] += (dynamic)a[row, i] * b[i, col];
                    }
                }
            }
            return product;
        }

        private static bool Bool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return Bool(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return Bool(matrix);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(this.matrix[row, col] + "    ");
                }
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }
    }

}
