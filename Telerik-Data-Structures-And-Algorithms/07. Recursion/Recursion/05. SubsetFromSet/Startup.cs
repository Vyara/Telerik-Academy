namespace SubsetFromSet
{
    using System;

    /// <summary>
    /// Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).
    /// Example: n=3, k=2, set = {hi, a, b
    /// } → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
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

                var elements = new string[n];
                Console.Write("Please enter {0} elements: ", n);
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("element[{0}] = ", i);
                    elements[i] = Console.ReadLine();
                }

                Console.WriteLine();
                Console.WriteLine(new string('-', 30));

                var variations = new int[n];
                GenerateVariations(0, k, n, elements, variations);
            }
        }

        private static void GenerateVariations(int index, int k, int n, string[] elements, int[] variations)
        {
            if (index >= k)
            {
                Print(k, elements, variations);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                variations[index] = i;
                GenerateVariations(index + 1, k, n, elements, variations);
            }
        }

        private static void Print(int k, string[] elements, int[] variations)
        {
            Console.Write(" { ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(elements[variations[i]] + " ");
            }

            Console.WriteLine("}");
        }
    }
}