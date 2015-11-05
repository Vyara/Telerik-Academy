namespace TraverseDirectory
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Common;

    public class Startup
    {
        public static void Main()
        {
            var initialPath = new DirectoryInfo(GlobalConstants.WindowsTraversePath);
            var result = TraversePath(initialPath);
            Console.WriteLine(result);
            Console.WriteLine(new string('-', 30));

            var file = GlobalConstants.ResultsTextFileName;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), file);

            var writer = File.CreateText(path);

            using (writer)
            {
                writer.Write(result);
                Console.WriteLine("Result file {0} is saved on the desktop", file);
            }
        }

        private static string TraversePath(DirectoryInfo dir)
        {
            var result = new StringBuilder();
            try
            {
                var exeExtentions = dir.GetFiles().Where(file => file.Extension == GlobalConstants.SearchedFileExtention);
                foreach (var file in exeExtentions)
                {
                    result.AppendLine(string.Format("Name: {0}", file.Name));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Directory {0} cannot be accessed.", dir.FullName);
                return string.Empty;
            }

            var directories = dir.GetDirectories();

            foreach (var directory in directories)
            {
                result.Append(TraversePath(directory));
            }

            return result.ToString();
        }
    }
}
