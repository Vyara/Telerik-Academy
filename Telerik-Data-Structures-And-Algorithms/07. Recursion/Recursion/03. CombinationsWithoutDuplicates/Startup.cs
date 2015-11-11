namespace CombinationsWithoutDuplicates
{
    using System;

    /// <summary>
    /// Modify the previous program to skip duplicates:
    /// n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Please enter a value of n: ");
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));

                Console.Write("Please enter a value of k: ");
                var k = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));

                var combinations = new int[n];

                GenerateCombinationsWithoutRepetitions(0, 0, n, k, combinations);
            }
        }

        private static void GenerateCombinationsWithoutRepetitions(int index, int start, int n, int k, int[] combinations)
        {
            if (index >= k)
            {
                PrintCombinations(combinations, k);
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    combinations[index] = i;
                    GenerateCombinationsWithoutRepetitions(index + 1, i + 1, n, k, combinations);
                }
            }
        }

        private static void PrintCombinations(int[] combinations, int k)
        {
            Console.Write(" ( ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(combinations[i] + 1 + " ");
            }

            Console.WriteLine(")");
        }
    }
}
