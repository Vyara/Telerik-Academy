// Task 11

// Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
// Use XPath query.
namespace ExtractPricesWithXPath
{
    using System;
    using System.Xml;

    public class PricesWithXPathMain
    {
       public static void Main()
        {
            var path = "/albums/album";
            var document = new XmlDocument();
            document.Load("../../catalog.xml");

            var albums = document.SelectNodes(path);

            Console.WriteLine("Album prices for albums published before or in 2010:");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            foreach (XmlNode album in albums)
            {
                var year = int.Parse(album.SelectSingleNode("year").InnerText);

                if (year <= 2010)
                {
                    var albumName = album.SelectSingleNode("name").InnerText;
                    var albumPrice = album.SelectSingleNode("price").InnerText;
                    Console.WriteLine("Album: {0}", albumName);
                    Console.WriteLine("Year: {0}", year);
                    Console.WriteLine("Price: {0}", albumPrice);
                    Console.WriteLine();
                }
            }
        }
    }
}
