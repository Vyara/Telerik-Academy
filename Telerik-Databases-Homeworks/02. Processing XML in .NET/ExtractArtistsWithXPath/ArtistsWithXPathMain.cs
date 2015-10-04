// Task 3

// Implement the previous using XPath.

namespace ExtractArtistsWithXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

   public class ArtistsWithXPathMain
    {
        public static void Main()
        {
            var document = new XmlDocument();
            document.Load("../../catalog.xml");
            var artists = GetAllUniqueArtists(document);

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

        private static Dictionary<string, int> GetAllUniqueArtists(XmlDocument rootNode)
        {
            var uniqueArtists = new Dictionary<string, int>();
            var allArtists = rootNode.SelectNodes("/albums/album/artist");

            foreach (XmlNode artist in allArtists)
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
