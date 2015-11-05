namespace FilesAndFolders
{
    using System;
    using System.Text;
    using Common;

    public class Startup
    {
        public static void Main()
        {
            var entryPoint = new Folder(GlobalConstants.FolderName, GlobalConstants.WindowsTraversePathForFiles);
            GetFolders(entryPoint);
            var result = new StringBuilder();
            FileSystem(entryPoint, result, 0);
            Console.WriteLine(result);
        }

        private static void FileSystem(Folder folder, StringBuilder result, int depth)
        {
            string indent = new string('.', depth * 3);

            result.AppendLine(string.Format("{0}{1} | Size: {2}", indent, folder.Name, folder.Size()));

            foreach (var file in folder.Files)
            {
                result.AppendLine(string.Format(".{0}-{1} | Size: {2}", indent, file.Name, file.Size));
            }

            foreach (var subFolder in folder.ChildFolders)
            {
                FileSystem(subFolder, result, depth + 1);
            }
        }

        private static void GetFolders(Folder folder)
        {
            foreach (var file in folder.Directory.GetFiles())
            {
                folder.Files.Add(new File(file.Name, file.Length));
            }

            foreach (var subDir in folder.Directory.GetDirectories())
            {
                var subFolder = new Folder(subDir.Name, subDir.FullName);
                folder.ChildFolders.Add(subFolder);
                GetFolders(subFolder);
            }
        }
    }
}
