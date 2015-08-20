//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

namespace LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        public static int maxLength = 0;

        static void Main()
        {
            var strings = new[]
            {
                "iuuwyr",
                "uiihdffahjsdfka",
                "a",
                "aksjksfka",
                "aksdlk"
            };

            var longestString =
                from str in strings
                where IsLongestString(str)
                select str;

            Console.WriteLine("Strings: ");
            Console.WriteLine(new string('-', 30));
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();
            Console.WriteLine("Longest String: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(longestString.Last());
        }

        //methods
        private static bool IsLongestString(string str)
        {
            
            if (str.Length > maxLength)
            {
                maxLength = str.Length;
                return true;
            }

            return false;
        }
    }
}
