// Task 6

// Rewrite the same using XDocument and LINQ query.

namespace ExtractAllSongTitlesWIthXDocumentAndLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class SongTitlesWithXDocumentAndLinqMain
    {
      public static void Main()
        {
            var document = XDocument.Load("../../catalog.xml");
            var albums = document.Element("albums").Elements("album");
            var albumTitles = from title in albums.Descendants("title") select title.Value;

            Console.WriteLine("Song titles: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));

            foreach (var title in albumTitles)
            {
                Console.WriteLine(title);
                Console.WriteLine();
            }
        }
    }
}
