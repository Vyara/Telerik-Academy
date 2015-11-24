namespace Brackets
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string expr = Console.ReadLine();
            int n = expr.Length;
            long[,] dp = new long[n + 1, n + 2];
            dp[0, 0] = 1;
            for (int k = 1; k <= n; k++)
            {
                if (expr[k - 1] == '(')
                {
                    dp[k, 0] = 0;
                }
                else
                {
                    dp[k, 0] = dp[k - 1, 1];
                }

                for (int c = 1; c <= n; c++)
                {
                    if (expr[k - 1] == '(')
                    {
                        dp[k, c] = dp[k - 1, c - 1];
                    }
                    else if (expr[k - 1] == ')')
                    {
                        dp[k, c] = dp[k - 1, c + 1];
                    }
                    else
                    {
                        dp[k, c] = dp[k - 1, c - 1] + dp[k - 1, c + 1];
                    }
                }
            }

            Console.WriteLine(dp[n, 0]);
        }
    }
}
