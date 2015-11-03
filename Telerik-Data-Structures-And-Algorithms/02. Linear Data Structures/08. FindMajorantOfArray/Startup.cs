namespace FindMajorantOfArray
{
    using System;
    using System.Linq;

    /// <summary>
    /// *The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    /// Write a program to find the majorant of given array(if exists).
    /// Example:
    /// {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var numbers = new[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Console.WriteLine("Sequence: [{0}]", string.Join(", ", numbers));
            Console.WriteLine(new string('-', 30));
            PrintMajorant(numbers);
        }

        private static void PrintMajorant(int[] numbers)
        {
            var groupedNumbers = numbers.GroupBy(n => n).OrderByDescending(n => n.Count()).FirstOrDefault();

            var isMajorantInSequence = (groupedNumbers != null) && (groupedNumbers.Count() > numbers.Count() / 2);

            if (isMajorantInSequence)
            {
                Console.WriteLine("The majorant in the sequence is the value: {0}", groupedNumbers.Key);
                Console.WriteLine("And it occurs {0} times", groupedNumbers.Count());
                Console.WriteLine(new string('-', 30));
            }
            else
            {
                Console.WriteLine("There is no majorant in this sequence.");
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
