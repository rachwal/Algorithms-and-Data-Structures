using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.Printer
{
    public class TreePrinter
    {
        public string BottomUpTraversal(TreeNode node)
        {
            var print = BottomUpTraversalRecurrence(node);
            return print.TrimEnd();
        }

        private string BottomUpTraversalRecurrence(TreeNode node)
        {
            if (node == null)
            {
                return string.Empty;
            }

            var print = new StringBuilder();

            print.Append(BottomUpTraversalRecurrence(node.Left));
            print.Append(BottomUpTraversalRecurrence(node.Right));

            print.Append($"{node.Value} ");
            return print.ToString();
        }

        public string DepthFirstTraversal(TreeNode node)
        {
            var print = DepthFirstTraversalRecurrence(node);
            return print.TrimEnd();
        }

        private string DepthFirstTraversalRecurrence(TreeNode node)
        {
            if (node == null)
            {
                return string.Empty;
            }
            var print = new StringBuilder();

            print.Append($"{node.Value} ");

            print.Append(DepthFirstTraversalRecurrence(node.Left));
            print.Append(DepthFirstTraversalRecurrence(node.Right));

            return print.ToString();
        }

        public string InOrderTraversal(TreeNode node)
        {
            var print = InOrderTraversalRecurrence(node);
            return print.TrimEnd();
        }

        private string InOrderTraversalRecurrence(TreeNode node)
        {
            if (node == null)
            {
                return string.Empty;
            }
            var print = new StringBuilder();

            print.Append(InOrderTraversalRecurrence(node.Left));
            print.Append($"{node.Value} ");
            print.Append(InOrderTraversalRecurrence(node.Right));

            return print.ToString();
        }

        public string BreadthFirstTraversal(TreeNode node)
        {
            if (node == null)
            {
                return string.Empty;
            }
            var print = new StringBuilder();

            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current == null)
                {
                    print.Append("# ");
                    continue;
                }
                print.Append($"{current.Value} ");

                queue.Enqueue(current.Left);
                queue.Enqueue(current.Right);
            }

            var result = print.ToString();
            return result.TrimEnd();
        }
    }
}