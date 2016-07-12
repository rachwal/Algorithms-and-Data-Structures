namespace DataStructures
{
    public class ListNode
    {
        public ListNode() : this(0)
        {
        }

        public ListNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public ListNode Next { get; set; }
    }
}