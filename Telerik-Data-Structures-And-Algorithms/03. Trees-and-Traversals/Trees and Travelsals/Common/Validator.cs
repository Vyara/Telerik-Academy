namespace Common
{
    using System;

    public class Validator
    {
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
