// Task 10

// Rewrite the last exercises using XDocument, XElement and XAttribute.

namespace TraverseADirectoryWithXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

   public class TraverseWithXDocument
    {
        public static void Main()
        {
            var path = @"C:\Temp\Databases-master";
            var databases = TraverseDocument(path);
            databases.Save("../../directory.xml");

            Console.WriteLine("directory.xml created");
        }

        private static XElement TraverseDocument(string directory)
        {
            var element = new XElement("dir", new XAttribute("path", directory));
            var directories = Directory.GetDirectories(directory);

            foreach (var dir in directories)
            {
                element.Add(TraverseDocument(dir));
            }

            var files = Directory.GetFiles(directory);

            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                var fileExtention = Path.GetExtension(file);

                element.Add(new XElement(
                    "file",
                    new XAttribute("name", fileName),
                    new XAttribute("extention", fileExtention)));
            }

            return element;
        }
    }
}
