namespace RetrieveArticles
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
            AddArticles(store);
            Timer.Stop();

            Console.WriteLine("Adding articles -> Elapsed time: {0}", Timer.Elapsed);

            Timer.Restart();
            SearchInPriceRange(store);
            Timer.Stop();

            Console.WriteLine("Searching articles -> Elapsed time: {0}", Timer.Elapsed);
        }

        private static void AddArticles(Store store, int numOfProductsToAdd = 500000)
        {
            for (int i = 0; i < numOfProductsToAdd; i++)
            {
                string title = Random.Next(int.MaxValue).ToString();
                decimal price = Random.Next(20000) / 100;
                store.AddArticle(new Article(title, price));
            }

            Console.WriteLine();
            Console.WriteLine("| Added {0} articles |", numOfProductsToAdd);
            Console.WriteLine();
        }

        private static void SearchInPriceRange(Store store, int numOfSearches = 5000000)
        {
            ICollection<Article> searchedArticles = null;
            var count = 0;

            for (int i = 0; i < numOfSearches; i++)
            {
                int min = Random.Next(200), max = Random.Next(250, 2000);
                searchedArticles = store.SearchInRange(min, max);
            }

            Console.WriteLine("First 20 articles: ");
            Console.WriteLine();

            foreach (var article in searchedArticles)
            {
                if (count < 20)
                {
                    Console.WriteLine(article.ToString());
                }

                count++;
            }

            Console.WriteLine();
            Console.WriteLine("| Searched {0} times |", numOfSearches);
            Console.WriteLine();
        }
    }
}
