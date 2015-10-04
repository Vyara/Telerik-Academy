// Task 4

// Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.

namespace DeleteAlbumsWithPriceLargerThan20UsingDomParser
{
    using System;
    using System.Xml;

    public class DeleteAlbumsWithPriceLargerThan20Main
    {
        public static void Main()
        {
            Console.WriteLine("All albums: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));

            var document = new XmlDocument();
            document.Load("../../catalog.xml");
            XmlElement rootNode = document.DocumentElement;

            DisplayAllAlbumsWithPrice(rootNode);

            Console.WriteLine("Albums with a price <= 20: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));

            DeleteElementAboveSpecificValue(rootNode, 20.0, "price");
            document.Save("../../updatedCatalog.xml");

            var updatedDocument = new XmlDocument();
            updatedDocument.Load("../../updatedCatalog.xml");
            XmlElement updatedRootNode = updatedDocument.DocumentElement;

            DisplayAllAlbumsWithPrice(updatedRootNode);
        }

        private static void DisplayAllAlbumsWithPrice(XmlElement root)
        {
            Console.WriteLine();

            foreach (XmlElement album in root)
            {
                var price = album["price"].InnerText;
                var albumName = album["name"].InnerText;

                Console.WriteLine("Album: {0}", albumName);
                Console.WriteLine("Price: {0}", price);
                Console.WriteLine();
            }
        }

        private static void DeleteElementAboveSpecificValue(XmlElement root, double maxValue, string value)
        {
            var elements = root.SelectNodes("album");

            foreach (XmlElement item in elements)
            {
                var itemValue = item[value].InnerText;
                var parcedItemValue = double.Parse(itemValue);

                if (parcedItemValue > maxValue)
                {
                    root.RemoveChild(item);
                }
            }
        }
    }
}
