namespace RemoveNumbersOccuringOddTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that removes from given sequence all numbers that occur odd number of times.
    /// Example:
    /// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
    /// </summary>
    public class Startup
    {
       public static void Main()
        {
            var numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var filteredSequence = FilterOutEvenNumbers(numbers);

            Console.WriteLine("Original List: [{0}]", string.Join(", ", numbers));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Sequence of numbers that occur even times: [{0}]", string.Join(", ", filteredSequence));
        }

        private static List<int> FilterOutEvenNumbers(List<int> numbers)
        {
            var groupedNumbers = numbers.GroupBy(n => n).Where(n => n.Count() % 2 == 0);
            var numbersOccuringEvenNumberOfTimes = new List<int>();

            foreach (var numberGroup in groupedNumbers)
            {
                numbersOccuringEvenNumberOfTimes.AddRange(numberGroup);
            }

            return numbersOccuringEvenNumberOfTimes;
        }
    }
}
