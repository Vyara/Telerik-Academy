namespace LinkedListImplementation
{
    public class ListNode<T>
    {
        public ListNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; }

        public ListNode<T> NextItem { get; set; }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
