namespace SuperSum
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            var k = int.Parse(numbers[0]);
            var n = int.Parse(numbers[1]);
            Console.WriteLine(CalculateSuperSum(k, n));
        }

        private static int CalculateSuperSum(int k, int n)
        {
            int ret = 0;
            if (k == 0)
            {
                return n;
            }

            for (int i = 1; i <= n; i++)
            {
                ret += CalculateSuperSum(k - 1, i);
            }

            return ret;
        }
    }
}
