// Task 12

// Rewrite the previous using LINQ query.

namespace ExtractPricesWithLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

   public class PricesWithLinqMain
    {
       public static void Main()
        {
            var document = XDocument.Load("../../catalog.xml");
            var albums = from album in document.Descendants("album")
                         where int.Parse(album.Element("year").Value) <= 2010
                         select new
                         {
                             Name = album.Element("name").Value,
                             Year = int.Parse(album.Element("year").Value),
                             Price = double.Parse(album.Element("price").Value)
                         };
            Console.WriteLine("Album prices for albums published before or in 2010:");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            foreach (var album in albums)
            {
                Console.WriteLine("Album: {0}", album.Name);
                Console.WriteLine("Year: {0}", album.Year);
                Console.WriteLine("Price: {0}", album.Price);
                Console.WriteLine();
            }
        }
    }
}
