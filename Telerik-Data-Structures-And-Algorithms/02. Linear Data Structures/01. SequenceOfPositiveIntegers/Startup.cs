namespace SequenceOfPositiveIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that reads from the console a sequence of positive integer numbers.
    /// The sequence ends when empty line is entered.
    /// Calculate and print the sum and average of the elements of the sequence.
    /// Keep the sequence in List<int>.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var numbers = new List<int>();

            Console.WriteLine("Please enter a number: ");
            var input = Console.ReadLine();

            int number;

            while (input != string.Empty)
            {
                if (int.TryParse(input, out number) && number > 0)
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                input = Console.ReadLine();
            }

            var sum = numbers.Sum();

            Console.WriteLine("The total sum of the numbers is: {0}", sum);
            Console.WriteLine(new string('-', 30));

            var average = numbers.Average();

            Console.WriteLine("The average of the numbers is: {0}", average);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }
    }
}
