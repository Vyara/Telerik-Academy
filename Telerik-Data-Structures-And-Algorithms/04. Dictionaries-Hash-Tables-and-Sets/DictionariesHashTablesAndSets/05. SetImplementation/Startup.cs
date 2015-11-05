namespace SetImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main()
        {
            var set = new Set<int>();

            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    set.Add(i);
                }
            }

            Console.WriteLine(set);
            Console.WriteLine(set.Count);

            var otherSet = new Set<int>();

            for (int i = 5; i < 16; i++)
            {
                otherSet.Add(i);
            }

            Console.WriteLine(otherSet);
            Console.WriteLine(otherSet.Count);
            Console.WriteLine(set.IntersectsWith(otherSet));
            Console.WriteLine(set.Union(otherSet));
        }
    }
}
