namespace ReadAndExecute
{
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var phoneBook = new PhoneBook();
            phoneBook.Add(new PhoneBookEntry("Isaac Newton", "Cambridge", "555 555 555"));
            phoneBook.Add(new PhoneBookEntry("Stephen Hawking", "Cambridge", "666 666 666"));
            phoneBook.Add(new PhoneBookEntry("Alan Turing", "Oxford", "777 777 777"));
            phoneBook.Add(new PhoneBookEntry("Ava Lovelace", "London", "111 111 111"));

            var resultByName = phoneBook.Find("Newton");
            var resultByNameAndTown = phoneBook.Find("Alan", "Oxford");
            var emptySearch = phoneBook.Find("testEntry");

            PrintResults(resultByName);
            PrintResults(resultByNameAndTown);
            PrintResults(emptySearch);
        }

        private static void PrintResults(ICollection<PhoneBookEntry> entries)
        {
            System.Console.WriteLine(string.Join(" ", entries));
            System.Console.WriteLine();
        }
    }
}