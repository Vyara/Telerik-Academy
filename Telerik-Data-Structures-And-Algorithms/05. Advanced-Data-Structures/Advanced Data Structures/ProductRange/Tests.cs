namespace ProductRange
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class Tests
    {
        private static readonly Random Random = new Random();
        private static readonly Stopwatch Timer = new Stopwatch();

        public static void Main()
        {
            var store = new Store();

            Console.Write("Calculating, please wait... ");
            Console.WriteLine();

            Timer.Start();
            AddProducts(store); 
            Timer.Stop();

            Console.WriteLine("Elapsed time: {0}", Timer.Elapsed);
            Console.WriteLine();

            Timer.Restart();
            SearchInPriceRange(store); 
            Timer.Stop();

            Console.WriteLine();
            Console.WriteLine("Elapsed time: {0}", Timer.Elapsed);
        }

        private static void AddProducts(Store store, int numOfProductsToAdd = 500000)
        {
            for (int i = 0; i < numOfProductsToAdd; i++)
            {
                string name = Random.Next(int.MaxValue).ToString();
                decimal price = Random.Next(20000) / 100;
                store.AddProduct(new Product(name, price));
            }

            Console.WriteLine();
            Console.WriteLine("| Added {0} products |", numOfProductsToAdd);
            Console.WriteLine();
        }

        private static void SearchInPriceRange(Store store, int numOfSearches = 10000)
        {
            ICollection<Product> firstTwenty = null;

            for (int i = 0; i < numOfSearches; i++)
            {
                int min = Random.Next(200), max = Random.Next(400, 1000);

                firstTwenty = store.SearchForFirst20InRange(min, max);
            }

            Console.WriteLine("Last 20 random products: ");
            Console.WriteLine();

            foreach (var product in firstTwenty)
            {
                Console.WriteLine(product.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("| Searched {0} times |", numOfSearches);
        }
    }
}
