/*
Download and install MySQL database, MySQL Connector/Net (.NET Data Provider for MySQL) + MySQL Workbench GUI administration tool.
Create a MySQL database to store Books (title, author, publish date and ISBN).
Write methods for listing all books, finding a book by name and adding a book.
*/
namespace MySQLBooks
{
    using System;
    using MySql.Data.MySqlClient;

    public class SearchBooks
    {
        public static void Main()
        {
            Console.Write("Enter MySQL password: ");
            string pass = Console.ReadLine();

            string connectionStr = "Server=localhost;Database=library;Uid=root;Pwd=" + pass + ";";
            var connection = new MySqlConnection(connectionStr);

            ListAllBooks(connection);
            Console.WriteLine();
            FindBookById(2, connection);
            Console.WriteLine();
            AddBook("The Grand Design", "Stephen Hawking", "111-111-111-11", connection);
            AddBook("Bring Me The Head Of Prince Charming", "Robert Sheckley", "222-222-222-22", connection);
        }

        private static void ListAllBooks(MySqlConnection connection)
        {
            connection.Open();
            using (connection)
            {
                var command = new MySqlCommand("select b.Name as Book, a.Name as Author from books as b " + "join authors as a " + "on a.Id = b.AuthorId", connection);
                MySqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("Books currently in library: ");
                Console.WriteLine();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(string.Format("- {0} -\t by {1}", reader["Book"], reader["Author"]));
                    }
                }
            }
        }

        private static void FindBookById(int id, MySqlConnection connection)
        {
            connection.Open();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand("select b.Name as Book, a.Name as Author from books as b " + "join authors as a " + "on a.Id = b.AuthorId " + "where b.Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("The book with id of " + id + " is: ");
                        Console.WriteLine(string.Format("- {0} -\t by {1}", reader["Book"], reader["Author"]));
                    }
                    else
                    {
                        Console.WriteLine("There is no book with id of " + id + " in the library.");
                    }
                }
            }
        }

        private static void AddBook(string name, string author, string isbn, MySqlConnection connection)
        {
            connection.Open();
            using (connection)
            {
                MySqlCommand checkAuthor = new MySqlCommand("select a.Id as Id from authors as a " + "join books as b " + "on a.Id = b.AuthorId " + "where a.Name = @author", connection);
                checkAuthor.Parameters.AddWithValue("@author", author);
                var reader = checkAuthor.ExecuteReader();

                int authorId;
                if (reader.Read())
                {
                    authorId = (int)reader["Id"];
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    MySqlCommand createAuthor = new MySqlCommand("insert into authors(Name) " + "values (@author)", connection);
                    createAuthor.Parameters.AddWithValue("@author", author);
                    createAuthor.ExecuteNonQuery();

                    Console.WriteLine("Author " + author + " added successfully!");

                    var cmdSelectIdentity = new MySqlCommand("select @@Identity", connection);
                    authorId = int.Parse(cmdSelectIdentity.ExecuteScalar().ToString());
                }

                MySqlCommand command = new MySqlCommand("insert into books(Name, AuthorId, ISBN) " + "values (@name, @authorId, @isbn)", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@authorId", authorId);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.ExecuteNonQuery();

                Console.WriteLine("Book " + name + " added successfully!");
            }
        }
    }
}
