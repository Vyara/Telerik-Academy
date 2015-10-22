namespace ReadNameAndScoreFromExcelFile
{
    using System;
    using System.Data.OleDb;

    public class ReadFromExcel
    {
        public static void Main()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
         @"Data Source=..\..\students.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'";

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                var command = new OleDbCommand("SELECT * FROM [Students$]", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader["Name"];
                        var score = reader["Score"];
                        Console.WriteLine("Name - {0}; Score - {1}", name, score);
                    }
                }
            }
        }
    }
}