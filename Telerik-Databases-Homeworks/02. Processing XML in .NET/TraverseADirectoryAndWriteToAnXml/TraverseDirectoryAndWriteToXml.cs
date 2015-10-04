// Task 9

// Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
// Use tags<file> and<dir> with appropriate attributes.
// For the generation of the XML document use the class XmlWriter.

namespace TraverseADirectoryAndWriteToAnXml
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class TraverseDirectoryAndWriteToXml
    {
        public static void Main()
        {
            var writer = new XmlTextWriter("../../directory.xml", Encoding.UTF8);

            using (writer)
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';

                var path = @"C:\Temp\Databases-master";

                writer.WriteStartDocument();
                writer.WriteStartElement("databases");
                TraverseDocument(path, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("directory.xml created");
        }

        private static void TraverseDirectory(string directory, XmlTextWriter writer)
        {
            foreach (var dir in Directory.GetDirectories(directory))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", dir);

                // recursively traverse directories
                TraverseDirectory(dir, writer);
                writer.WriteEndElement();
            }
        }

        private static void TraverseFile(string directory, XmlTextWriter writer)
        {
            foreach (var file in Directory.GetFiles(directory))
            {
                writer.WriteStartElement("file");
                var fileName = Path.GetFileNameWithoutExtension(file);
                writer.WriteAttributeString("name", fileName);

                var fileExtention = Path.GetExtension(file);
                writer.WriteAttributeString("extention", fileExtention);
                writer.WriteEndElement();
            }
        }

        private static void TraverseDocument(string directory, XmlTextWriter writer)
        {
            TraverseDirectory(directory, writer);
            TraverseFile(directory, writer);
        }
    }
}
