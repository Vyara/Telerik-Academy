// Task 8

// Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, 
// in which stores in appropriate way the names of all albums and their authors.

namespace ReadCatalogAndWriteToAlbum
{
    using System;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;

    public class CatalogToAlbum
    {
        public static void Main()
        {
            var writer = new XmlTextWriter("../../album.xml", Encoding.UTF8);

            using (writer)
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                var reader = new XmlTextReader("../../catalog.xml");

                using (reader)
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                var albumName = reader.ReadElementString();
                                writer.WriteElementString("name", albumName);
                            }
                            else if (reader.Name == "artist")
                            {
                                var artistName = reader.ReadElementString();
                                writer.WriteElementString("artist", artistName);
                                writer.WriteEndElement();
                            }
                        }
                    }
                }

                writer.WriteEndDocument();
            }

            Console.WriteLine("albums.xml created");
            Console.WriteLine(new string('-', 30));
            var document = XDocument.Load("../../album.xml");
            var albumElements = document.Element("albums").Elements("album");

            foreach (var album in albumElements)
            {
                var albumName = album.Element("name").Value;
                Console.WriteLine("Album: {0}", albumName);

                var albumArtist = album.Element("artist").Value;
                Console.WriteLine("Artist: {0}", albumArtist);
                Console.WriteLine();
            }
        }
    }
}
