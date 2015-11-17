namespace DayOfTheWeek
{
    using System;
    using System.Globalization;

    public class DayOfTheWeekService : IDayOfTheWeekService
    {
        public string DayOfWeekBulgarian(DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException("Date cannot be null");
            }

            var cultureBG = new CultureInfo("bg-BG");

            string dayOfWeekBul = cultureBG.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);

            return dayOfWeekBul;
        }
    }
}
