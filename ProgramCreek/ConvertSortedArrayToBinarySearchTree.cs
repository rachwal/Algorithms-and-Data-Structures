using DataStructures;

namespace ProgramCreek
{
    public class ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBst(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

            return SortedArrayToBst(array, 0, array.Length - 1);
        }

        private TreeNode SortedArrayToBst(int[] array, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var middle = (start + end)/2;
            var root = new TreeNode(array[middle])
            {
                Left = SortedArrayToBst(array, start, middle - 1),
                Right = SortedArrayToBst(array, middle + 1, end)
            };
            return root;
        }
    }
}