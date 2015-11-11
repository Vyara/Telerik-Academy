namespace AllSubsetsOfKStrings
{
    using System;

    /// <summary>
    /// Write a program for generating and printing all subsets of k strings from given set of strings.
    /// Example: s = {test, rock, fun
    /// }, k=2 → (test rock), (test fun), (rock fun)
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Please enter number of elements in set s: ");
                var s = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));

                var elements = new string[s];
                Console.Write("Please enter {0} elements: ", s);
                Console.WriteLine();
                for (int i = 0; i < s; i++)
                {
                    Console.Write("element[{0}] = ", i);
                    elements[i] = Console.ReadLine();
                }

                Console.WriteLine();
                Console.WriteLine(new string('-', 30));

                Console.Write("Please enter a value of k: ");
                var k = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));

                var variations = new int[s];
                GenerateVariations(0, 0, k, s, elements, variations);
            }
        }

        private static void GenerateVariations(int index, int start, int k, int n, string[] elements, int[] variations)
        {
            if (index >= k)
            {
                Print(k, elements, variations);
                return;
            }

            for (int i = start; i < n; i++, start++)
            {
                variations[index] = i;
                GenerateVariations(index + 1, start + 1, k, n, elements, variations);
            }
        }

        private static void Print(int k, string[] elements, int[] variations)
        {
            Console.Write(" ( ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(elements[variations[i]] + " ");
            }

            Console.WriteLine(")");
        }
    }
}