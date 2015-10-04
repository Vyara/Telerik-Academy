namespace GenerateAndValidateXsdSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

   public class ValidateXsd
    {
        public static void Main()
        {
            var xsd = new XmlSchemaSet();
            xsd.Add(string.Empty, "../../catalog.xsd");

            XDocument xml = XDocument.Load("../../catalog.xml");
            XDocument invalidXml = XDocument.Load("../../invalidCatalog.xml");

            ValidateXml(xml, xsd, "catalog.xml");
            ValidateXml(invalidXml, xsd, "invalidCatalog.xml");
        }

        private static void ValidateXml(XDocument document, XmlSchemaSet schema, string documentName)
        {
            document.Validate(
                schema, 
                (obj, ev) =>
            {
                Console.WriteLine("Document: {0}", documentName);
                Console.WriteLine("Validation: {0}", ev.Message);
                Console.WriteLine();
            });
        }
    }
}
