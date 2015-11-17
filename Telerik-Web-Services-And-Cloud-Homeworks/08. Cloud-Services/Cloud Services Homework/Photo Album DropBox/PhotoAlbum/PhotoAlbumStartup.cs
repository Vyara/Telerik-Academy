namespace PhotoAlbum
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using DropNet;

    public class PhotoAlbumStartuo
    {
        [STAThread]
        internal static void Main(string[] args)
        {
            Console.WriteLine("Please login in your dropbox account.");
            Console.WriteLine(new string('-', 30));
            Console.Write("Press any key when ready");
            Console.ReadLine();
            Console.WriteLine(new string('-', 30));

            var currentDir = Directory.GetCurrentDirectory();
            var dirFiles = new DirectoryInfo(currentDir).Parent.Parent;

           var pictures = dirFiles.GetFiles("*.jpg");

           var chosenPhotosIndexes = new List<int>();

            PrintAndChoosePictures(pictures, chosenPhotosIndexes);

            DropNetClient client = new DropNetClient("0yfo5pqlswvwahb", "vi8gx0704m78ahy");

            var token = client.GetToken();
            var url = client.BuildAuthorizeUrl();

            Clipboard.SetText(url);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("App Url was copied to clipboard. Please paste it in your browser and click \"Allow\".");
            Console.WriteLine();
            Console.Write("Press any key when ready");
            Console.ReadKey(true);

            var accessToken = client.GetAccessToken();

            client.UserLogin.Secret = accessToken.Secret;
            client.UserLogin.Token = accessToken.Token;

            client.UseSandbox = true;

            Console.WriteLine();
            Console.Write("Please enter an album name: ");
            var albumName = Console.ReadLine();

            var folder = client.CreateFolder(albumName);

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Uploading...");

            foreach (var index in chosenPhotosIndexes)
            {
                MemoryStream sr = new MemoryStream((int)pictures[index].Length);
                FileStream fs = File.Open(pictures[index].FullName, FileMode.Open);

                var bytes = new byte[fs.Length];

                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));

                client.UploadFile(folder.Path, pictures[index].Name, bytes);

                fs.Close();
            }

            var shareUrl = client.GetShare(folder.Path);

            Clipboard.SetText(shareUrl.Url);

            Console.WriteLine("Url: {0}", shareUrl.Url);
            Console.WriteLine();
            Console.WriteLine("Sharing Url copied to clipboard. Enjoy the cat pics!");
        }

        private static void PrintAndChoosePictures(FileInfo[] pictures, List<int> indexes)
        {
            int index = 0;
            Console.WriteLine("Pictures in current folder are: ");
            Console.WriteLine(new string('-', 30));
            foreach (var picture in pictures)
            {
                Console.WriteLine("index {0}: {1}", index, picture.Name);
                index++;
            }

            Console.WriteLine();
            Console.Write("Please enter the indexes of the photos you wish to add to your dropbox, separated by blank space: ");

            string[] chosen = Console.ReadLine().Trim().Split();

            foreach (var item in chosen)
            {
                indexes.Add(int.Parse(item));
            }
        }
    }
}