﻿namespace FilesAndFolders
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Folder
    {
        public Folder(string name, string path)
        {
            this.Name = name;
            this.Directory = new DirectoryInfo(path);
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public DirectoryInfo Directory { get; set; }

        public long Size()
        {
            return this.Files.Sum(file => file.Size) + this.ChildFolders.Sum(folder => folder.Size());
        }
    }
}
