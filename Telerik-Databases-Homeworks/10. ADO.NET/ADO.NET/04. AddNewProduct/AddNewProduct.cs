/*
Write a method that adds a new product in the products table in the Northwind database.
Use a parameterized SQL command.
*/
namespace AddNewProduct
{
    using System;
    using System.Data.SqlClient;

    public class AddNewProduct
    {
        public static void Main()
        {
            var dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=Northwind; Integrated Security=true");

            dbCon.Open();

            using (dbCon)
            {
                AddProduct(dbCon, "Nutella", 20, 3, "500 gr", 5.0m, 200, 50, 20, false);
                var cmdNewProduct = new SqlCommand("SELECT * FROM Products WHERE ProductName = 'Nutella'", dbCon);

                var reader = cmdNewProduct.ExecuteReader();

                while (reader.Read())
                {
                    var productId = (int)reader["ProductID"];
                    var productName = (string)reader["ProductName"];
                    var productPrice = (int)(decimal)reader["UnitPrice"];
                    Console.WriteLine("New product added:");
                    Console.WriteLine("Id: {0}, Name: {1}, Price: {2} ", productId, productName, productPrice);
                    Console.WriteLine();
                }
            }
        }

        private static void AddProduct(SqlConnection dbCon, string productName, int supplierId, int categoryId, string quantityPerUnit, decimal unitPrice, int unitsInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            var cmdInsertProject = new SqlCommand("INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit" + ",UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " + "VALUES (@productName, @supplierId, @categoryId, @quantityPerUnit, " + "@unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", dbCon);
            cmdInsertProject.Parameters.AddWithValue("@productName", productName);
            cmdInsertProject.Parameters.AddWithValue("@supplierId", supplierId);
            cmdInsertProject.Parameters.AddWithValue("@categoryId", categoryId);
            cmdInsertProject.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            cmdInsertProject.Parameters.AddWithValue("@unitPrice", unitPrice);
            cmdInsertProject.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            cmdInsertProject.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            cmdInsertProject.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            cmdInsertProject.Parameters.AddWithValue("@discontinued", discontinued ? 1 : 0);
            cmdInsertProject.ExecuteNonQuery();

            var cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
            var insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
        }
    }
}
