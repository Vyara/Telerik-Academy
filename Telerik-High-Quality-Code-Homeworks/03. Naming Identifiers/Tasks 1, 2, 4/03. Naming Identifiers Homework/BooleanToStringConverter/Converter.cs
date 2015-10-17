namespace BooleanToStringConverter
{
    public class Converter
    {
        private const int MaxCount = 6; ////no usage for this here, but will leave it with a proper name

        public string BoolToString(bool booleanValue)
        {
            var valueAsString = booleanValue.ToString();
            return valueAsString;
        }
    }
}
