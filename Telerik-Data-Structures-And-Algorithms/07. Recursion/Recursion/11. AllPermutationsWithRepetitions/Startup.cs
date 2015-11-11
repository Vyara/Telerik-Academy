namespace AllPermutationsWithRepetitions
{
    using System;

    /// <summary>
    /// *Write a program to generate all permutations with repetitionsof given multi-set.
    /// Example: the multi-set {1, 3, 5, 5}
    /// has the following 12 unique permutations:
    ///  { 1, 3, 5, 5 }  { 1, 5, 3, 5 }
    ///  { 1, 5, 5, 3 }  { 3, 1, 5, 5 }
    ///  { 3, 5, 1, 5 }  { 3, 5, 5, 1 }
    ///  { 5, 1, 3, 5 }  { 5, 1, 5, 3 }
    ///  { 5, 3, 1, 5 }  { 5, 3, 5, 1 }
    ///  { 5, 5, 1, 3 }  { 5, 5, 3, 1 }
    /// Ensure your program efficiently avoids duplicated permutations.
    /// Test it with { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var firstSet = new int[] { 1, 3, 5, 5 };
            var secondSet = new int[] { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            Array.Sort(firstSet);
            Array.Sort(secondSet);
            Console.WriteLine("Set: {{{0}}}", string.Join(", ", firstSet));
            Console.WriteLine(new string('-', 20));
            PermuteRep(firstSet, 0, firstSet.Length);
            Console.WriteLine();

            Console.WriteLine("Set: {{{0}}}", string.Join(", ", secondSet));
            Console.WriteLine(new string('-', 100));
            PermuteRep(secondSet, 0, secondSet.Length);
        }

        public static void PermuteRep(int[] set, int start, int n)
        {
            Print(set);

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (set[left] != set[right])
                    {
                        Swap(ref set[left], ref set[right]);
                        PermuteRep(set, left + 1, n);
                    }
                }

                var firstElement = set[left];
                for (int i = left; i < n - 1; i++)
                {
                    set[i] = set[i + 1];
                }

                set[n - 1] = firstElement;
            }
        }

        public static void Print<T>(T[] arr)
        {
            Console.Write("{");
            Console.Write(string.Join(", ", arr));
            Console.WriteLine("}");
        }

        public static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
