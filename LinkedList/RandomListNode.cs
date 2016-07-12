namespace DataStructures
{
    public class RandomListNode
    {
        public RandomListNode() : this(0)
        {
        }

        public RandomListNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public RandomListNode Next { get; set; }
        public RandomListNode Random { get; set; }
    }
}