namespace DayOfTheWeekConsoleClient
{
    using System;
    using System.Text;
    using DayOfTheWeekServiceReference;

    public class Startup
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var client = new DayOfTheWeekServiceClient();

            Console.WriteLine("Денят днес е {0}.", client.DayOfWeekBulgarianAsync(DateTime.Now).Result);
        }
    }
}
