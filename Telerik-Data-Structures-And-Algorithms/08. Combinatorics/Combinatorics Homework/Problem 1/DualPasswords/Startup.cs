namespace DualPasswords
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var password = Console.ReadLine();
            int unknownDigits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '*')
                {
                    unknownDigits++;
                }
            }

            ulong result = 1;

            for (int i = 1; i <= unknownDigits; i++)
            {
                result <<= 1;
            }

            Console.WriteLine(result);
        }
    }
}
