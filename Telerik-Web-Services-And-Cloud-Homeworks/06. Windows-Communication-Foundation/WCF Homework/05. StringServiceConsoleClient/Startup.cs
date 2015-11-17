namespace StringServiceConsoleClient
{
    using System;
    using AppearancesCounterServiceReference;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Please enter a phrase to be searched for: ");
            var occuringString = Console.ReadLine();
            Console.WriteLine(new string('-', 30));

            Console.Write("Please enter a string to count the phrase \"{0}\" appearances in it : ", occuringString);
            var containingStringgString = Console.ReadLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            var client = new AppearancesCounterClient();
            int result = client.CountStringAppearances(occuringString, containingStringgString);
            Console.WriteLine("String \"{0}\" contains the phrase \"{1}\" {2} times.", containingStringgString, occuringString, result);
        }
    }
}
