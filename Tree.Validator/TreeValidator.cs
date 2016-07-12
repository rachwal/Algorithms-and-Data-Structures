namespace DataStructures.Tree.Validator
{
    public class TreeValidator
    {
        public bool ValidateBst(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var value = root.Value;
            if (root.Left != null && root.Left.Value >= value)
            {
                return false;
            }

            if (root.Right != null && root.Right.Value <= value)
            {
                return false;
            }

            return ValidateBst(root.Left) && ValidateBst(root.Right);
        }
    }
}