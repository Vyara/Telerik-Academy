namespace NumberOfOccurences
{
    using System;
    using System.Linq;

    /// <summary>
    /// Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
    /// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    /// 2 → 2 times
    /// 3 → 4 times
    /// 4 → 3 times
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var numbers = new[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var groupedNumbers = numbers.GroupBy(n => n).OrderBy(n => n.Key);

            Console.WriteLine("List: [{0}]", string.Join(", ", numbers));
            Console.WriteLine(new string('-', 30));

            foreach (var numberGroup in groupedNumbers)
            {
                Console.WriteLine("{0} occurs {1} times", numberGroup.Key, numberGroup.Count());
            }
        }
    }
}
