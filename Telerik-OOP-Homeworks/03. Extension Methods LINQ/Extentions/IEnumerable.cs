//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
namespace Extentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            //validates data
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Cannot sum elements in an empty collection.");
            }

            //sums elements
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            //validates data
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Cannot multiply elements in an empty collection.");
            }

            //multiplies elements
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            //validates data
            if (collection.Count() == 0)
            {
                throw new ArgumentException("No min element in an empty collection.");
            }

            T min = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(min) <= 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            //validates data
            if (collection.Count() == 0)
            {
                throw new ArgumentException("No max element in an empty collection.");
            }

            T max = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> collection)
        {
            //validates data
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Cannot calculate average of elements in an empty collection.");
            }

            dynamic sum = default(T);
            decimal count = 0M;

            foreach (var item in collection)
            {
                sum += item;
                count++;
            }

            var average = sum / count;
            
            return average;
        }
    }
}
