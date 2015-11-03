namespace ReverseIntegersWithStack
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a program that reads N integers from the console and reverses them using a stack.
    /// Use the Stack<int> class.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            string input;
            int n;

            do
            {
                Console.Write("Please enter the number of integers N: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out n));

            int number;
            var numbers = new Stack<int>();

            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter element {0}: ", i);

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Please enter a valid number: ");
                }

                numbers.Push(number);
            }

            Console.WriteLine("Reversed numbers: ");
            Console.WriteLine(new string('-', 30));

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
