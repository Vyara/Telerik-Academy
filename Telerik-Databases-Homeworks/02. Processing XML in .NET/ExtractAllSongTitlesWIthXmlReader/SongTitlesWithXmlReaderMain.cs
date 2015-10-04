// Task 5

// Write a program, which using XmlReader extracts all song titles from catalog.xml.

namespace ExtractAllSongTitlesWIthXmlReader
{
    using System;
    using System.Xml;

    public class SongTitlesWithXmlReaderMain
    {
      public static void Main()
        {
            var reader = new XmlTextReader("../../catalog.xml");
            Console.WriteLine("Song titles: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));

            using (reader)
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        var title = reader.ReadElementString();
                        Console.WriteLine(title);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
