namespace NestedLoops
{
    using System;

    /// <summary>
    /// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
    /// Examples:
    ///        1 1
    /// n=2  ->  1 2
    ///         2 1
    ///        2 2
    ///
    ///         1 1 1
    ///         1 1 2
    ///          1 1 3
    ///          1 2 1
    /// n=3  ->  ...
    ///          3 2 3
    ///          3 3 1
    ///          3 3 2
    ///          3 3 3
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Please enter the integer n: ");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("{0} nested loops simulation: ", number);
                Console.WriteLine();
                var numbers = new int[number];
                SimulateNestedLoops(numbers, 0);
            }
        }

        private static void SimulateNestedLoops(int[] numbers, int i)
        {
            if (i == numbers.Length)
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }

            for (int j = 1; j <= numbers.Length; j++)
            {
                numbers[i] = j;
                SimulateNestedLoops(numbers, i + 1);
            }
        }
    }
}
