namespace RemoveAllNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that removes from given sequence all negative numbers.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var numbers = new List<int>();

            Console.WriteLine("Please enter numbers: ");
            var input = Console.ReadLine();

            int number;

            while (input != string.Empty)
            {
                if (int.TryParse(input, out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                input = Console.ReadLine();
            }

            var positiveSequence = numbers.Where(n => n >= 0);

            Console.WriteLine("Original List: [{0}]", string.Join(", ", numbers));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Positive numbers only: [{0}]", string.Join(", ", positiveSequence));
        }
    }
}
