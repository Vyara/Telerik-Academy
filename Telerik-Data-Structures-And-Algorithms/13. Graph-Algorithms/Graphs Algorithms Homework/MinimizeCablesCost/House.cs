namespace MinimizeCablesCost
{
    public class House
    {
        public House(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }

        public override string ToString()
        {
            return this.Id;
        }

        public override bool Equals(object obj)
        {
            return this.Id.Equals(((House)obj).Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
