namespace CountWordAppearances
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Write a program that counts how many times each word 
    /// from given text file words.txt appears in it.
    /// The character casing differences should be ignored. The result words should be ordered by their number of occurrences in the text. 
    /// Example:
    /// This is the TEXT.Text, text, text – THIS TEXT! Is this the text?
    /// is -> 2
    /// the -> 2
    /// this -> 3
    /// text -> 6
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var text = "This is the TEXT.Text, text, text – THIS TEXT!Is this the text?";
            Console.WriteLine("Initial text: {0}", text);
            Console.WriteLine(new string('-', 80));

            Regex.Matches(text, "[A-Za-z0-9]+")
               .Cast<Match>()
               .Select(m => m.Value.ToLower())
               .GroupBy(x => x)
               .OrderBy(x => x.Count())
               .ToList()
               .ForEach((x) =>
               {
                   Console.WriteLine("{0} -> {1}", x.Key, x.Count());
                   Console.WriteLine();
               });
        }
    }
}
