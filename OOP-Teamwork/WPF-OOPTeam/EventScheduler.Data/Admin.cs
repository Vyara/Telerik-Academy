namespace EventScheduler.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [Serializable]

    public class Admin : Organizer
    {
        // TODO: encapsulate and implement
        public int Event { get; set; }

        public string Name { get; set; }

        private static string password = "mypass";

        public static bool IsCorrect(string s)
        {
            return password == s;
        }
        
        public void AddEvent()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEvent()
        {
            throw new System.NotImplementedException();
        }
    }
}
