namespace Cars.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Producer
    {
        public Producer(string name, IEnumerable<string> models)
        {
            this.Name = name;
            this.Models = models.ToList();
        }

        public string Name { get; private set; }

        public List<string> Models { get; private set; }
    }
}