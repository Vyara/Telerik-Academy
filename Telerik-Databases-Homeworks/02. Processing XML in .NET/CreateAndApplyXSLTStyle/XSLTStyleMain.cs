// Task 13
// Create an XSL stylesheet, which transforms the file catalog.xml into HTML document, formatted for viewing in a standard Web-browser.

// Task 14
// Write a C# program to apply the XSLT stylesheet transformation on the file catalog.xml using the class XslTransform.
namespace CreateAndApplyXsltStyle
{
    using System;
    using System.Xml.Xsl;

    public class XsltStyleMain
    {
        public static void Main()
        {
            XslCompiledTransform xsltStyle = new XslCompiledTransform();
            xsltStyle.Load("../../catalogstyle.xslt");
            xsltStyle.Transform("../../catalog.xml", "../../catalog.html");
            Console.WriteLine("catalog.html created");
        }
    }
}
