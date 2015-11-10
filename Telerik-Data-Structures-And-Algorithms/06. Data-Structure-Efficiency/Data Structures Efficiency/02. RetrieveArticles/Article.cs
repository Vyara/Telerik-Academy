namespace RetrieveArticles
{
    using System;

    public class Article : IComparable<Article>
    {
        public Article(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article other)
        {
            return (int)(this.Price - other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} -> {2:C}", this.GetType().Name, this.Name, this.Price);
        }
    }
}
