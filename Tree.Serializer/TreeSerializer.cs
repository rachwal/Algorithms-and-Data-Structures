namespace DataStructures.Tree.Serializer
{
    public class TreeSerializer
    {
        public TreeNode DeserializeDfs(string values)
        {
            var elements = values.Split(' ');
            return DeserializeDfs(elements, 0, elements.Length - 1);
        }

        private TreeNode DeserializeDfs(string[] values, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var middle = (start + end)/2;
            var value = 0;

            if (int.TryParse(values[middle], out value))
            {
                var left = DeserializeDfs(values, start, middle - 1);
                var node = new TreeNode(value);
                var right = DeserializeDfs(values, middle + 1, end);
                node.Left = left;
                node.Right = right;
                return node;
            }
            return null;
        }
    }
}