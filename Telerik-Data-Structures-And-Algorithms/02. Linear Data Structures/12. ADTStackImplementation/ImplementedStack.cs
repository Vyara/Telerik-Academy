namespace ADTStackImplementation
{
    using System;

    public class ImplementedStack<T>
    {
        private T[] items;

        public ImplementedStack()
        {
            this.items = new T[4];
        }

        public int Count { get; set; }

        public void Push(T value)
        {
            if (this.Count >= this.items.Length)
            {
                Array.Resize(ref this.items, this.items.Length * 2);
            }

            this.items[this.Count] = value;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No more elements in stack");
            }

            T result = this.items[this.Count - 1];
            this.Count--;

            return result;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No more elements in stack");
            }

            return this.items[this.Count - 1];
        }
    }
}
