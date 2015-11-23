namespace SortingHomework.Utils
{
    using System;
    using System.Collections.Generic;

    public class RandomCollectionGenerator
    {
        private static Random random = new Random();

        public static IList<int> GetRandomIntegers(int integersCount)
        {
            IList<int> randomIntegers = new List<int>(integersCount);

            for (int i = 0; i < integersCount; i++)
            {
                randomIntegers.Add(random.Next());
            }

            return randomIntegers;
        }

        public static IList<int> GetSortedIntegers(int integersCount)
        {
            IList<int> sortedIntegers = new List<int>(integersCount);

            for (int i = 0; i < integersCount; i++)
            {
                sortedIntegers.Add(i);
            }

            return sortedIntegers;
        }

        public static IList<int> GetReversedIntegers(int integersCount)
        {
            IList<int> reversedIntegers = new List<int>(integersCount);

            for (int i = integersCount; i > 0; i--)
            {
                reversedIntegers.Add(i);
            }

            return reversedIntegers;
        }
    }
}
