namespace CombinationsWithDuplicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a recursive program for generating and printing all the combinations with duplicatesof k elements from n-element set. Example:
    /// n=3, k=2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
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

                GenerateCombinationsWithRepetitions(0, 0, n, k, combinations);
            }
        }

       private static void GenerateCombinationsWithRepetitions(int index, int start, int n, int k, int[] combinations)
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
                    GenerateCombinationsWithRepetitions(index + 1, i, n, k, combinations);
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
