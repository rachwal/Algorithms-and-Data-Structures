using System;
using Syslo.Data_Structures;

namespace Syslo
{
    public class Huffman
    {
        public TreeNode BuildTree(double[] weights)
        {
            var count = weights.Length;
            var weightNodes = new TreeNode[count];
            var huffmanTree = new TreeNode[count];

            Array.Sort(weights);

            for (var i = 0; i < count; i++)
            {
                weightNodes[i] = new TreeNode
                {
                    Value = weights[i],
                    Left = null,
                    Right = null
                };
            }

            huffmanTree[0] = new TreeNode
            {
                Left = weightNodes[0],
                Right = weightNodes[1],
                Value = weightNodes[0].Value + weightNodes[1].Value,
            };

            var start = 0;
            var end = 0;

            var current = 2;

            for (var i = 1; i < count; i++)
            {
                TreeNode leftChild;
                TreeNode rightChild;

                end++;

                if (current < count)
                {
                    if (weightNodes[current].Value <= huffmanTree[start].Value)
                    {
                        leftChild = weightNodes[current];
                        current++;
                    }
                    else
                    {
                        leftChild = huffmanTree[start];
                        start++;
                    }

                    if (current < count)
                    {
                        if (start > end)
                        {
                            rightChild = weightNodes[current];
                        }
                        else
                        {
                            if (weightNodes[current].Value <= huffmanTree[start].Value)
                            {
                                rightChild = weightNodes[current];
                                current = current + 1;
                            }
                            else
                            {
                                rightChild = huffmanTree[start];
                                start = start + 1;
                            }
                        }
                    }
                    else
                    {
                        rightChild = huffmanTree[start];
                        start++;
                    }
                }
                else
                {
                    leftChild = huffmanTree[start];
                    rightChild = huffmanTree[start + 1];
                    start = start + 2;
                }

                huffmanTree[end] = new TreeNode
                {
                    Value = Convert.ToDouble(leftChild?.Value + rightChild?.Value),
                    Left = leftChild,
                    Right = rightChild,
                };
            }

            return huffmanTree[end].Left;
        }
    }
}