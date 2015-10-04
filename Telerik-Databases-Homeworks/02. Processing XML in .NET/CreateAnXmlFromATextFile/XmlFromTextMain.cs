// Taks 7

// In a text file we are given the name, address and phone number of given person (each at a single line).
// Write a program, which creates new XML document, which contains these data in structured XML format.

namespace CreateAnXmlFromATextFile
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class XmlFromTextMain
    {
        public static void Main()
        {
            var reader = new StreamReader("../../personInfo.txt");

            string personName;
            string personAddress;
            string personPhone;

            using (reader)
            {
                personName = reader.ReadLine();
                personAddress = reader.ReadLine();
                personPhone = reader.ReadLine();
            }

            var person = new XElement(
                "person",
                new XElement("name", personName),
                new XElement("address", personAddress),
                new XElement("phone", personPhone));

            Console.WriteLine("Saving person element to person.xml...");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            person.Save("../../person.xml");

            var document = XDocument.Load("../../person.xml");
            var personElement = document.Element("person");
            var personElementName = personElement.Element("name").Value;
            Console.WriteLine("Person: {0}", personElementName);
            Console.WriteLine();

            var personElementAdress = personElement.Element("address").Value;
            Console.WriteLine("Adress: {0}", personElementAdress);
            Console.WriteLine();

            var personElementPhone = personElement.Element("phone").Value;
            Console.WriteLine("Phone: {0}", personElementPhone);
            Console.WriteLine();
        }
    }
}
