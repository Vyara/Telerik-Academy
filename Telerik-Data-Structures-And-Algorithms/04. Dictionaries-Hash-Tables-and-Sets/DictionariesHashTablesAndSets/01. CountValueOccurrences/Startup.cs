namespace CountValueOccurrences
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a program that counts in a given array of double values the number of occurrences of each value.
    ///  Use Dictionary<TKey,TValue>.
    /// Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
    /// -2.5 -> 2 times
    /// 3 -> 4 times
    /// 4 -> 3 times
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            double[] inputNumbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var numbers = string.Join(", ", inputNumbers);
            Console.WriteLine("Initial array: {0}", numbers);
            Console.WriteLine(new string('-', 30));

            var result = new Dictionary<double, int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                double numberToAdd = inputNumbers[i];
                if (!result.ContainsKey(numberToAdd))
                {
                    result.Add(numberToAdd, 1);
                }
                else
                {
                    result[numberToAdd] += 1;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine("Number {0} occurs {1} times", item.Key, item.Value);
            }
        }
    }
}
