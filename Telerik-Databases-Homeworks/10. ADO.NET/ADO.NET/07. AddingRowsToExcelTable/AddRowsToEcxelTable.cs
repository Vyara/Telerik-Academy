/*
Implement appending new rows to the Excel file.
*/
namespace AddingRowsToExcelTable
{
    using System.Data.OleDb;

    public class AddRowsToEcxelTable
    {
       public static void Main()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                    @"Data Source=..\..\students.xlsx; Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                for (int i = 0; i < 10; i++)
                {
                    var command = new OleDbCommand(@"INSERT INTO [Students$] Values(@name, @score)", connection);

                    command.Parameters.AddWithValue("@name", "Student" + i);
                    command.Parameters.AddWithValue("@score", 100 + (10 * i) + (i % 10));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
