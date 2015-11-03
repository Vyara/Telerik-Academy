namespace LongestSeqenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
    /// Write a program to test whether the method works correctly.
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

            GetLongestSeqence(numbers);
        }

        private static void GetLongestSeqence(List<int> numbers)
        {
            int sequence = 0;
            int longestSequence = 0;
            int startingIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    var isLastElementAndSequenceIsLongerThanMax = (i == numbers.Count - 1) && (sequence > longestSequence);
                    sequence++;
                    if (isLastElementAndSequenceIsLongerThanMax)
                    {
                        longestSequence = sequence;
                        startingIndex = i - longestSequence + 1;
                    }
                }
                else
                {
                    if (sequence > longestSequence)
                    {
                        longestSequence = sequence;
                        startingIndex = i - longestSequence;
                    }

                    sequence = 1;
                }
            }

            List<int> finalSequence = new List<int>();

            for (int i = 0; i < longestSequence; i++)
            {
                finalSequence.Add(numbers[startingIndex]);
            }

            Console.WriteLine("The longest sequence of equal numbers in [{0}] is: ", string.Join(", ", numbers));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("[{0}] with {1} elements", string.Join(", ", finalSequence), longestSequence);
        }
    }
}
