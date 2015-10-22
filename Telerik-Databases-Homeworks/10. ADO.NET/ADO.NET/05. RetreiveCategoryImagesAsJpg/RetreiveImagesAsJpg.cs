/*
Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.
*/
namespace RetreiveCategoryImagesAsJpg
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class RetreiveImagesAsJpg
    {
        public static void Main()
        {
            GetImagesFromDB(
                    "Data Source=.\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = SSPI",
                    "SELECT CategoryName, Picture FROM Categories",
                    "CategoryName",
                    "Picture",
                    ".jpg",
                    "../../");
        }

        private static void WriteBinaryFile(string fileName, int offset, byte[] fileContents)
        {
            var stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, offset, fileContents.Length - offset);
            }
        }

        private static void GetImagesFromDB(string connectionString, string query, string nameColumn, string pictureColumn, string format, string path)
        {
            var dbConn = new SqlConnection(connectionString);
            dbConn.Open();

            using (dbConn)
            {
                var cmd = new SqlCommand(query, dbConn);
                var reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var name = (string)reader[nameColumn];
                        var escapedName = name.Replace(@"/", @"-");
                        var picture = (byte[])reader[pictureColumn];
                        Console.WriteLine("Creating " + escapedName + format);
                        WriteBinaryFile(path + escapedName + format, 78, picture);
                    }
                }
            }
        }
    }
}
