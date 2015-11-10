namespace RetrieveArticles
{
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class Store
    {
        private OrderedMultiDictionary<decimal, Article> articles = new OrderedMultiDictionary<decimal, Article>(true);

        public OrderedMultiDictionary<decimal, Article> Products
        {
            get
            {
                return this.articles;
            }

            set
            {
                this.articles = value;
            }
        }

        public void AddArticle(Article article)
        {
            this.articles[article.Price].Add(article);
        }

        public ICollection<Article> SearchInRange(decimal from, decimal to)
        {
            return this.articles.Range(from, true, to, true).Values;
        }
    }
}
