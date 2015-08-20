namespace EventScheduler.Data.Exceptions
{
    using System;

    class Validator
    {
        public static void CheckIfObjectIsNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfLengthIsValid(string text, int max, int min = 0, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public static void CheckIfLengthIsAtLeastNSymbols(string text, int min, string message = null)
        {
            if (text.Length < min)
            {
                throw new ArgumentOutOfRangeException(message);
           }
        }

    }
}
