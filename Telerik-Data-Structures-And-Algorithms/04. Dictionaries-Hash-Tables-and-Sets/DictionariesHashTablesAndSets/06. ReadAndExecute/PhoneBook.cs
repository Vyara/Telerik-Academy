namespace ReadAndExecute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class PhoneBook
    {
        private readonly Dictionary<string, HashSet<PhoneBookEntry>> entries;

        public PhoneBook()
        {
            this.entries = new Dictionary<string, HashSet<PhoneBookEntry>>();
        }

        public void Add(PhoneBookEntry entry)
        {
            var splittedNames = entry.Name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in splittedNames)
            {
                if (this.entries.ContainsKey(name))
                {
                    this.entries[name].Add(entry);
                }
                else
                {
                    this.entries.Add(name, new HashSet<PhoneBookEntry>() { entry });
                }
            }
        }

        public ICollection<PhoneBookEntry> Find(string name)
        {
            if (this.entries.ContainsKey(name))
            {
                return this.entries[name];
            }
            else
            {
                return new List<PhoneBookEntry>();
            }
        }

        public ICollection<PhoneBookEntry> Find(string name, string town)
        {
            return this.Find(name).Where(x => x.Town == town).ToList();
        }
    }
}
