namespace NaturalPermutations
{
    using System;

    /// <summary>
    /// Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n. Example:
    /// n=3 → {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Please enter the integer n: ");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine(new string('-', 30));
                var numbers = new int[number];
                for (int i = 0; i < number; i++)
                {
                    numbers[i] = i + 1;
                }

                GeneratePermutations(numbers, 0);
            }
        }

       public static void GeneratePermutations<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
            {
                Print(arr, k);
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

        private static void Print<T>(T[] arr, int k)
        {
            Console.Write(" {");
            Console.Write(string.Join(", ", arr));
            Console.WriteLine("}");
        }
    }
}
