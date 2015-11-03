namespace FindFirst50Members
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// We are given the following sequence:
    /// S1 = N;
    /// S2 = S1 + 1;
    /// S3 = 2* S1 + 1;
    /// S4 = S1 + 2;
    /// S5 = S2 + 1;
    /// S6 = 2* S2 + 1;
    /// S7 = S2 + 2;
    /// ...
    /// Using the Queue<T> class write a program to print its first 50 members for given N.
    /// Example: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            PrintFirstNMembers(2, 50);
        }

        private static void PrintFirstNMembers(int start, int length)
        {
            var initialValues = new Queue<int>();
            initialValues.Enqueue(start);
            var resultsequence = new Queue<int>();

            while (resultsequence.Count < length)
            {
                int baseNumber = initialValues.Dequeue();
                resultsequence.Enqueue(baseNumber);
                initialValues.Enqueue(baseNumber + 1);
                initialValues.Enqueue((2 * baseNumber) + 1);
                initialValues.Enqueue(baseNumber + 2);
            }

            Console.WriteLine("First {0} members for the given N {1} are: ", length, start);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("[{0}]", string.Join(", ", resultsequence));
        }
    }
}
