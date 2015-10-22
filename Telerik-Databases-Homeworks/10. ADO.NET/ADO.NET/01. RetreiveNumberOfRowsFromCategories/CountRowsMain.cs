/* 
Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
*/
namespace RetreiveNumberOfRowsFromCategories
{
    using System;
    using System.Data.SqlClient;

    public class CountRowsMain
    {
        public static void Main()
        {
            var dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=Northwind; Integrated Security=true");

            dbCon.Open();

            using (dbCon)
            {
                var cmdCountRows = new SqlCommand("SELECT COUNT (*) FROM Categories", dbCon);

                var categoriesRowsCount = (int)cmdCountRows.ExecuteScalar();

                Console.WriteLine("Number of rows in Categories: ");
                Console.WriteLine(new string('-', 30));
                Console.WriteLine(categoriesRowsCount);
            }
        }
    }
}
