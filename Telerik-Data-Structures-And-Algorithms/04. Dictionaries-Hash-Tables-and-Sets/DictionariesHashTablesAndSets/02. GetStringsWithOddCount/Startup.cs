namespace GetStringsWithOddCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. 
    /// Example: {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var result = new List<string>();

            string input = "C#, SQL, PHP, PHP, SQL, SQL";
            Console.WriteLine("Initial string: {0}", input);
            Console.WriteLine(new string('-', 30));

            input
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(x => x)
                .ToList()
                .ForEach((x) =>
                {
                    if (x.Count() % 2 == 1)
                    {
                        result.Add(x.Key);
                    }
                });

            Console.WriteLine("Elements that occur odd number of times: {0}", string.Join(", ", result));
        }
    }
}
