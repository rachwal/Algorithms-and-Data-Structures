using System;
using System.Collections.Generic;
using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class BinaryTreeDepth
    {
        public int GetMax(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(GetMax(root.Left), GetMax(root.Right)) + 1;
        }

        public int GetMinDft(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.Left == null)
            {
                return GetMinDft(root.Right) + 1;
            }
            if (root.Right == null)
            {
                return GetMinDft(root.Left) + 1;
            }

            return Math.Min(GetMinDft(root.Left), GetMinDft(root.Right)) + 1;
        }

        public int GetMinBft(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var rightMost = root;
            var depth = 1;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.Left == null && node.Right == null)
                {
                    break;
                }

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }

                if (node == rightMost)
                {
                    depth++;
                    rightMost = node.Right != null ? node.Right : node.Left;
                }
            }
            return depth;
        }
    }
}