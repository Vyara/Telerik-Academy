namespace StringApperancesService
{
    using System;

    public class AppearancesCounter : IAppearancesCounter
    {
        public int CountStringAppearances(string occuringString, string containingString)
        {
            if (string.IsNullOrWhiteSpace(occuringString) || string.IsNullOrWhiteSpace(containingString))
            {
                throw new ArgumentNullException("Input strings cannot be null or empty.");
            }

            int result = 0;
            int startingIndex = 0;

            while (startingIndex != -1)
            {
                int searchResult = containingString.IndexOf(occuringString, startingIndex);

                startingIndex = searchResult + occuringString.Length;
                if (searchResult != -1)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
