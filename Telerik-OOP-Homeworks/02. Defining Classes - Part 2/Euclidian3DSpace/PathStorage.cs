//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.

namespace Euclidian3DSpace
{
    using System;
    using System.Linq;
    using Text = System.IO;

    public static class PathStorage
    {
        //methods
        public static void SavePath(Path path, string name)
        {
            string fullPath = Text.Path.Combine("..\\..\\Paths", String.Format("{0}.txt", name.Trim()));

            var writer = Text.File.CreateText(fullPath);

            using (writer)
            {
                writer.Write(path);
            }
        }

        public static Path LoadPath(string name)
        {
            Path filePath = new Path();

            string fullPath = Text.Path.Combine("..\\..\\Paths", String.Format("{0}.txt", name.Trim()));

            try
            {
                var reader = new Text.StreamReader(fullPath);
                using (reader)
                {
                    var points = reader.ReadToEnd().Split(new string[] {"-"}, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var point in points)
                    {
                        var coordinates = point.Trim('{').Trim('}').Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                        var newPoint = new Point3D(double.Parse(coordinates[0]), double.Parse(coordinates[1]), double.Parse(coordinates[2]));

                        filePath.AddPoint(newPoint);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return null;
            }

            return filePath;
        }
    }
}