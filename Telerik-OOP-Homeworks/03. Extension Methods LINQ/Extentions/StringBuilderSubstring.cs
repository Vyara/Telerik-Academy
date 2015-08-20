//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
namespace Extentions
{
    using System;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            var substring = new StringBuilder();

            //validates input
            if (index < 0 || index >= str.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (length < 0)
            {
                throw new ArgumentException("Length must be > 0.");
            }

            if (index + length >= str.Length)
            {
                throw new ArgumentException("Substring length must be within the boundaries of the original string.");
            }

            //creates substring
            for (int i = 0; i < length; i++)
            {
                substring.Append(str[index + i]);
            }

            return substring;
        }
    }
    }
