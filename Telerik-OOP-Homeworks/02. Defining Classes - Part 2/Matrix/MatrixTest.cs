namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MatrixTest
    {
        static void Main()
        {
            var gen = new Random();
            var matrixA = new Matrix<int>(2, 2);
            for (int i = 0; i < matrixA.Rows; i++)
            {
                for (int j = 0; j < matrixA.Cols; j++)
                {
                    matrixA[i, j] = gen.Next(10);
                }
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Matrix A:");
            Console.WriteLine(matrixA.ToString());

            var matrixB = new Matrix<int>(2, 2);
            for (int i = 0; i < matrixB.Rows; i++)
            {
                for (int j = 0; j < matrixB.Cols; j++)
                {
                    matrixB[i, j] = gen.Next(10);
                }
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Matrix B:");
            Console.WriteLine(matrixA.ToString());

            var sum = matrixA + matrixB;
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Sum:");
            Console.WriteLine(sum.ToString());

            var difference = matrixA - matrixB;
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Difference:");
            Console.WriteLine(difference.ToString());

            var product = matrixA * matrixB;
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Product:");
            Console.WriteLine(product.ToString());

        }
    }
}
