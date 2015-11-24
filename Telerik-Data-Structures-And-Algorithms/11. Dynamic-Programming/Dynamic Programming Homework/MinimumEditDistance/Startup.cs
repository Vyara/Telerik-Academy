namespace MinimumEditDistance
{
    using System;

    public class Startup
    {
        private const decimal DeletionCost = 0.9m;
        private const decimal InsertionCost = 0.8m;

        private static string firstString = "evelo2per";
        private static string secondString = "enveloped";

        private static int length = Math.Max(firstString.Length, secondString.Length);
        private static decimal[,] f = new decimal[length + 1, length + 1];
        private static int n1;
        private static int n2;

        public static void Main()
        {
            n1 = firstString.Length - 1;
            n2 = secondString.Length - 1;
            Console.WriteLine("Minimal distance between two strings: {0}", EditDistance());
            PrintEditOperations(n1, n2);

            Console.WriteLine();
        }

        private static int GetReplacementCost(int i, int j)
        {
            return firstString[i] == secondString[j] ? 0 : 1;
        }

        private static decimal EditDistance()
        {
            int i, j;
            for (i = 0; i <= n1; i++)
            {
                f[i, 0] = i * DeletionCost;
            }

            for (j = 0; j <= n2; j++)
            {
                f[0, j] = j * InsertionCost;
            }

            for (i = 1; i <= n1; i++)
            {
                for (j = 1; j <= n2; j++)
                {
                    decimal replace = f[i - 1, j - 1] + GetReplacementCost(i, j);
                    decimal insert = f[i, j - 1] + InsertionCost;
                    decimal delete = f[i - 1, j] + DeletionCost;
                    f[i, j] = Min(replace, insert, delete);
                }
            }

            return f[n1, n2];
        }

        private static decimal Min(decimal replace, decimal insert, decimal delete)
        {
            decimal smaller = replace < insert ? replace : insert;
            decimal smallest = smaller < delete ? smaller : delete;

            return smallest;
        }

        private static void PrintEditOperations(int i, int j)
        {
            if (j == 0)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("Delete({0}) ", j);
                }
            }
            else if (i == 0)
            {
                for (i = 1; i <= j; i++)
                {
                    Console.Write("Insert({0}, {1}) ", i, secondString[i]);
                }
            }
            else if (i > 0 && j > 0)
            {
                if (f[i, j] == f[i - 1, j - 1] + GetReplacementCost(i, j))
                {
                    PrintEditOperations(i - 1, j - 1);
                    if (GetReplacementCost(i, j) > 0)
                    {
                        Console.Write("Replace({0},{1}) ", i, secondString[j]);
                    }
                }
                else if (f[i, j] == f[i, j - 1] + InsertionCost)
                {
                    PrintEditOperations(i, j - 1);
                    Console.Write("Insert({0},{1}) ", i, secondString[j]);
                }
                else if (f[i, j] == f[i - 1, j] + DeletionCost)
                {
                    PrintEditOperations(i - 1, j);
                    Console.Write("Delete({0}) ", i);
                }
            }
        }
    }
}
