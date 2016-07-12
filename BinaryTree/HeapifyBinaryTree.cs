using System;
using System.Collections.Generic;
using DataStructures;

namespace LeetCode.Algorithms.BinaryTree
{
    public class TreeNodeComparer : IComparer<TreeNode>
    {
        public int Compare(TreeNode x, TreeNode y)
        {
            if (x == null && y == null)
            {
                return 0;
            }

            if (x == null)
            {
                return -1;
            }

            if (y == null)
            {
                return 1;
            }

            return x.Value.CompareTo(y.Value);
        }
    }

    public class HeapifyBinaryTree
    {
        public TreeNode Heapify(TreeNode root)
        {
            var size = Traverse(root, 0, null);
            var nodeArray = new TreeNode[size];
            Traverse(root, 0, nodeArray);

            Array.Sort(nodeArray, new TreeNodeComparer());

            for (var i = 0; i < size; i++)
            {
                var left = 2*i + 1;
                var right = left + 1;
                nodeArray[i].Left = left >= size ? null : nodeArray[left];
                nodeArray[i].Right = right >= size ? null : nodeArray[right];
            }
            return nodeArray[0];
        }

        private int Traverse(TreeNode node, int count, TreeNode[] array)
        {
            if (node == null)
            {
                return count;
            }

            if (array != null)
            {
                array[count] = node;
            }

            count++;

            count = Traverse(node.Left, count, array);
            count = Traverse(node.Right, count, array);

            return count;
        }
    }
}