namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;
    using Common;

    public class CustomNode<T> 
    {
        private readonly IList<CustomNode<T>> children;

        public CustomNode(T value)
        {
            this.Value = value;
            this.HasParent = false;
            this.children = new List<CustomNode<T>>();
        }

        public T Value { get; set; }

        public bool HasParent { get; set; }

        public IList<CustomNode<T>> Children
        {
            get { return this.children; }
        }

        public int ChildrenCount
        {
            get { return this.children.Count; }
        }

        public CustomNode<T> GetChild(int index)
        {
            return this.children[index];
        }

        public void AddChild(CustomNode<T> child)
        {
            Validator.CheckIfNull(child, ValidationConstants.ObjectIsNullMessage);

            if (child.HasParent)
            {
                throw new ArgumentException(ValidationConstants.NodeAlreadyHasAParentMessage);
            }

            child.HasParent = true;
            this.Children.Add(child);
        }

        public void AddChildren(params CustomNode<T>[] children)
        {
            foreach (var child in children)
            {
                Validator.CheckIfNull(child, ValidationConstants.ObjectIsNullMessage);

                if (child.HasParent)
                {
                    throw new ArgumentException(ValidationConstants.NodeAlreadyHasAParentMessage);
                }

                child.HasParent = true;
                this.Children.Add(child);
            }
        }

        public void RemoveAt(int index)
        {
            this.children.RemoveAt(index);
        }

        public T GetSubSum()
        {
            dynamic sum = this.Value;

            foreach (var child in this.Children)
            {
                sum += child.GetSubSum();
            }

            return (T)sum;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
