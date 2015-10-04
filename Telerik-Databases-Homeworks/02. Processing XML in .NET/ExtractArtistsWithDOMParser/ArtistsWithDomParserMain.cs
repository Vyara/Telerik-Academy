// Task 2

// Write program that extracts all different artists which are found in the catalog.xml.
// For each author you should print the number of albums in the catalogue.
// Use the DOM parser and a hash-table.

namespace ExtractArtistsWithDomParser
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

   public class ArtistsWithDomParserMain
    {
       public static void Main()
        {
            var document = new XmlDocument();
            document.Load("../../catalog.xml");
            XmlElement rootNode = document.DocumentElement;
            var artists = GetAllUniqueArtists(rootNode);

            Console.WriteLine();

            foreach (var artistAndAlbums in artists)
            {
                Console.WriteLine("Artist: {0}", artistAndAlbums.Key);
                Console.WriteLine("Number of albums: {0}", artistAndAlbums.Value);
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));
                Console.WriteLine();
            }
        }

        private static Dictionary<string, int> GetAllUniqueArtists(XmlElement rootNode)
        {
            var uniqueArtists = new Dictionary<string, int>();
            var allArtists = rootNode.GetElementsByTagName("artist");

            foreach (XmlElement artist in allArtists)
            {
                var artistName = artist.InnerText;

                if (uniqueArtists.ContainsKey(artistName))
                {
                    uniqueArtists[artistName] += 1;
                }
                else
                {
                    uniqueArtists.Add(artistName, 1);
                }
            }

            return uniqueArtists;
        }
    }
}
