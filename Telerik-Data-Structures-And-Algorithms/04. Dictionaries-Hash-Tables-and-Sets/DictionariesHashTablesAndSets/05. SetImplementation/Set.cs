namespace SetImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using HashTableImplementation;

    public class Set<T> : IEnumerable<T>
    {
        private CustomHashTable<int, T> elements;

        public Set()
        {
            this.elements = new CustomHashTable<int, T>();
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        public void Add(T element)
        {
            this.elements.Add(element.GetHashCode(), element);
        }

        public void Remove(T element)
        {
            this.elements.Remove(element.GetHashCode());
        }

        public void Clear()
        {
            this.elements.Clear();
        }

        public T Find(T element)
        {
            T elementToReturn;

            if (this.elements.Find(element.GetHashCode(), out elementToReturn))
            {
                return elementToReturn;
            }

            return default(T);
        }

        public Set<T> IntersectsWith(Set<T> other)
        {
            var result = new Set<T>();

            foreach (var node in this)
            {
                foreach (var otherNode in other)
                {
                    if (node.Equals(otherNode))
                    {
                        result.Add(node);
                    }
                }
            }

            return result;
        }

        public Set<T> Union(Set<T> other)
        {
            var result = new Set<T>();

            foreach (var node in this)
            {
                result.Add(node);
            }

            foreach (var otherNode in other)
            {
                result.Add(otherNode);
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var pair in this.elements)
            {
                yield return pair.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this);
        }
    }
}
