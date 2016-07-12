namespace DataStructures
{
    public class TreeNode
    {
        public TreeNode() : this(0)
        {
        }

        public TreeNode(int value)
        {
            Value = value;
        }

        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Value { get; set; }
    }
}