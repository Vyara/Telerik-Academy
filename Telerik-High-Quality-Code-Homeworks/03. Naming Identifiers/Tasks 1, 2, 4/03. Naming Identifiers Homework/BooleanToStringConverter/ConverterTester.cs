namespace BooleanToStringConverter
{
    using System;

    public class ConverterTester
    {
        public static void Main()
        {
            var converter = new Converter();

            var boolAsString = converter.BoolToString(true);
            Console.WriteLine(boolAsString);
        }
    }
}