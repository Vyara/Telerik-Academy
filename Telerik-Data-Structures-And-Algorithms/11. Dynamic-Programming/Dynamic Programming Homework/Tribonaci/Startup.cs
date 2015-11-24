namespace Tribonaci
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            var t1 = long.Parse(numbers[0]);
            var t2 = long.Parse(numbers[1]);
            var t3 = long.Parse(numbers[2]);
            var n = long.Parse(numbers[3]);

            if (n == 1)
            {
                Console.WriteLine(t1);
            }
            else if (n == 2)
            {
                Console.WriteLine(t2);
            }
            else if (n == 3)
            {
                Console.WriteLine(t3);
            }
            else
            {
                for (int i = 4; i <= n; i++)
                {
                    long tribNew = t1 + t2 + t3;
                    t1 = t2;
                    t2 = t3;
                    t3 = tribNew;
                }

                Console.WriteLine(t3);
            }
        }
    }
}
