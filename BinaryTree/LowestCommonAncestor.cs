using System.Collections.Generic;
using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class LowestCommonAncestor
    {
        public int Find(TreeNode root, int first, int second)
        {
            if (first > second)
            {
                return Find(root, second, first);
            }
            var leftParents = GetParents(root, first);
            var rightParents = GetParents(root, second);

            var prev = root.Value;

            while (leftParents.Count > 0 && rightParents.Count > 0)
            {
                var l = leftParents.Dequeue();
                var r = rightParents.Dequeue();
                if (l == r)
                {
                    prev = l;
                }
                else
                {
                    break;
                }
            }

            return prev;
        }

        private Queue<int> GetParents(TreeNode root, int value)
        {
            var parents = new Queue<int>();
            ExploreTree(root, value, parents);
            return parents;
        }

        private void ExploreTree(TreeNode node, int value, Queue<int> parents)
        {
            if (node == null || node.Value == value)
            {
                return;
            }

            parents.Enqueue(node.Value);

            if (node.Value > value)
            {
                ExploreTree(node.Left, value, parents);
            }
            else
            {
                ExploreTree(node.Right, value, parents);
            }
        }
    }
}