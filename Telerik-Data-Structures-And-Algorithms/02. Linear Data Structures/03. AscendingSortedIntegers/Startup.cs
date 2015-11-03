namespace AscendingSortedIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
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

            numbers.Sort();

            Console.WriteLine("The sorted numbers are: {0}", string.Join(", ", numbers));
        }
    }
}
