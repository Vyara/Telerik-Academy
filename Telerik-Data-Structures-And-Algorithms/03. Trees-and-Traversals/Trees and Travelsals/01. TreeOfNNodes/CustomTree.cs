namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common;

    public class CustomTree<T> where T : IComparable<T>
    {
        public CustomTree()
        {
            this.Children = new List<CustomNode<T>>();
            this.Size = 0;
        }

        public List<CustomNode<T>> Children { get; set; }

        public int Size { get; set; }

        public CustomNode<T> Find(T value)
        {
            CustomNode<T> node;

            for (int i = 0; i < this.Children.Count; i++)
            {
                node = this.Find(this.Children[i], value);
                if (node != null)
                {
                    return node;
                }
            }

            return null;
        }

        public CustomNode<T> Find(CustomNode<T> startingNode, T value)
        {
            if ((dynamic)startingNode.Value == (dynamic)value)
            {
                startingNode.HasParent = false;
                return startingNode;
            }

            for (int i = 0; i < startingNode.ChildrenCount; i++)
            {
                startingNode = this.Find(startingNode.GetChild(i), value);
            }

            return startingNode;
        }

        public bool Contains(T value)
        {
            if (this.Children.Count == 0)
            {
                return false;
            }

            bool isFound = false;

            for (int i = 0; i < this.Children.Count; i++)
            {
                isFound = this.Contains(this.Children[i], value);
                if (isFound)
                {
                    return isFound;
                }
            }

            return false;
        }

        public bool Contains(CustomNode<T> startingNode, T value)
        {
            if ((dynamic)startingNode.Value == (dynamic)value)
            {
                return true;
            }

            bool isFound = false;
            for (int i = 0; i < startingNode.ChildrenCount; i++)
            {
                isFound = this.Contains(startingNode.GetChild(i), value);
                if (isFound)
                {
                    return isFound;
                }
            }

            return false;
        }

        public void RemoveTreeNode(CustomNode<T> theNodeToRemove)
        {
            theNodeToRemove.HasParent = false;
            this.Children.Remove(theNodeToRemove);
        }

        public void TraverseDfs(CustomNode<T> root, string spaces)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine("root: {1} --> spaces: {0}", root.Value, spaces);

            CustomNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                this.TraverseDfs(child, spaces + "   ");
            }
        }

        public void AttachExisting(CustomNode<T> startNode, CustomNode<T> parentNode, T childValue)
        {
            if ((dynamic)startNode.Value == (dynamic)parentNode.Value)
            {
                parentNode = startNode;
            }

            CustomNode<T> currenNode = null;
            for (int i = 0; i < startNode.ChildrenCount; i++)
            {
                currenNode = startNode.GetChild(i);
                if ((dynamic)currenNode.Value == (dynamic)childValue)
                {
                    parentNode.AddChild(currenNode);
                    startNode.RemoveAt(i);
                    return;
                }
            }

            this.AttachExisting(currenNode, parentNode, childValue);
        }

        public void TraverseNode(CustomNode<T> startNode, string result)
        {
            if (startNode == null)
            {
                return;
            }

            Console.WriteLine(result + startNode.Value);

            for (int i = 0; i < startNode.ChildrenCount; i++)
            {
                this.TraverseNode(startNode.GetChild(i), result + "-");
            }
        }

        public void Add(CustomNode<T> node)
        {
            this.Size++;
            this.Children.Add(node);
        }

        public void AttachTo(CustomNode<T> startNode, T parentNodeValue, T childValue)
        {
            if ((dynamic)startNode.Value == (dynamic)parentNodeValue)
            {
                startNode.AddChild(new CustomNode<T>(childValue));
                return;
            }

            CustomNode<T> currenNode = null;
            for (int i = 0; i < startNode.ChildrenCount; i++)
            {
                currenNode = startNode.GetChild(i);
                this.AttachTo(currenNode, parentNodeValue, childValue);
            }
        }

        public List<CustomNode<T>> GetAllLeafs()
        {
            return this.GetAllLeafs(this.Children[0], new List<CustomNode<T>>());
        }

        public List<CustomNode<T>> GetAllMiddleLeafs()
        {
            return this.GetAllMiddleLeafs(this.Children[0], new List<CustomNode<T>>());
        }

        public List<CustomNode<T>> GetAllMiddleLeafs(CustomNode<T> startNode, List<CustomNode<T>> listToFill)
        {
            if (startNode.ChildrenCount != 0 && startNode.HasParent)
            {
                listToFill.Add(startNode);
            }

            for (int i = 0; i < startNode.ChildrenCount; i++)
            {
                listToFill = this.GetAllMiddleLeafs(startNode.GetChild(i), listToFill);
            }

            return listToFill;
        }

        public List<CustomNode<T>> GetAllLeafs(CustomNode<T> startNode, List<CustomNode<T>> listToFill)
        {
            if (startNode.ChildrenCount == 0)
            {
                listToFill.Add(startNode);
                return listToFill;
            }

            for (int i = 0; i < startNode.ChildrenCount; i++)
            {
                listToFill = this.GetAllLeafs(startNode.GetChild(i), listToFill);
            }

            return listToFill;
        }

        public int LongestPath()
        {
            return this.GetPath(this.Children[0], 0, 0);
        }

        public int GetPath(CustomNode<T> root, int maxLevel, int currentLevel)
        {
            if (maxLevel < currentLevel)
            {
                maxLevel = currentLevel;
            }

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                maxLevel = this.GetPath(root.GetChild(i), maxLevel, currentLevel + 1);
            }

            return maxLevel;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < this.Children.Count; i++)
            {
                this.TraverseNode(this.Children[i], result.ToString());
            }

            return result.ToString();
        }
    }
}
