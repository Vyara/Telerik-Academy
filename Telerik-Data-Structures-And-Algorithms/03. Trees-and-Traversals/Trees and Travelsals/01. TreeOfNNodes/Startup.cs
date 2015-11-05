namespace TreeOfNNodes
{
    using System;
    using System.IO;
    using System.Linq;
    using Common;

    public class Startup
    {
        public static void Main()
        {
            var tree = new CustomTree<int>();
            var reader = new StringReader(GlobalConstants.TreeInput);

            SolveTasks(reader, tree);
            PrintResult(tree);
        }

        private static void SolveTasks(StringReader reader, CustomTree<int> tree)
        {
            int nodePairsCount;
            string firstLine = reader.ReadLine();
            if (!int.TryParse(firstLine, out nodePairsCount))
            {
                throw new ArgumentException(ValidationConstants.InvalidInput);
            }

            for (int i = 0; i < nodePairsCount - 1; i++)
            {
                string[] line = reader.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                int parentValue = int.Parse(line[0]);
                int childValue = int.Parse(line[1]);

                if (!tree.Contains(parentValue) && !tree.Contains(childValue))
                {
                    var theNewNode = new CustomNode<int>(parentValue);
                    theNewNode.AddChild(new CustomNode<int>(childValue));
                    tree.Add(theNewNode);
                }
                else if (!tree.Contains(parentValue) && tree.Contains(childValue))
                {
                    var theNode = new CustomNode<int>(parentValue);
                    var theNodeToAdd = tree.Find(childValue);
                    tree.RemoveTreeNode(theNodeToAdd);
                    theNode.AddChild(theNodeToAdd);
                    tree.Add(theNode);
                }
                else if (tree.Contains(parentValue) && !tree.Contains(childValue))
                {
                    var theNode = tree.Find(parentValue);
                    theNode.AddChild(new CustomNode<int>(childValue));
                }
                else
                {
                    var theParentNode = tree.Find(parentValue);
                    var theChildNode = tree.Find(childValue);
                    tree.RemoveTreeNode(theChildNode);
                    theParentNode.AddChild(theChildNode);
                }
            }
        }

        private static void PrintResult(CustomTree<int> tree)
        {
            Console.WriteLine(tree.ToString());
            Console.WriteLine("Root: " + tree.Children[0].Value);
            var leaves = tree.GetAllLeafs().Select(x => x.Value).ToList();
            Console.WriteLine("Leaves: {0}", string.Join(", ", leaves));
            Console.WriteLine("Deepest level: {0}", tree.LongestPath());
            var middleNodes = tree.GetAllMiddleLeafs().Select(x => x.Value).ToList();
            Console.WriteLine("Middle nodes: {0}", string.Join(", ", middleNodes));
        }
    }
}