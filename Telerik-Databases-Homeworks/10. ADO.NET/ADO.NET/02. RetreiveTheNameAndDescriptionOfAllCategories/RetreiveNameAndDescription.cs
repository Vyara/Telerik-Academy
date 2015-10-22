/*
Write a program that retrieves the name and description of all categories in the Northwind DB.
*/
namespace RetreiveTheNameAndDescriptionOfAllCategories
{
    using System;
    using System.Data.SqlClient;

    public class RetreiveNameAndDescription
    {
        public static void Main()
        {
            var dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                var cmdGetNameAndDescription = new SqlCommand(
                    "SELECT CategoryID, CategoryName, Description FROM Categories", dbCon);

                var reader = cmdGetNameAndDescription.ExecuteReader();

                Console.WriteLine("Id |   Name                  | Description");
                Console.WriteLine(new string('-', 100));

                while (reader.Read())
                {
                    var categoryId = (int)reader["CategoryID"];
                    var categoryName = (string)reader["CategoryName"];
                    var description = (string)reader["Description"];

                    Console.WriteLine("{0}  |   {1}  | {2}", categoryId, categoryName.PadRight(20), description);
                }
            }
        }
    }
}
