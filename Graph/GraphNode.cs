namespace DataStructures
{
    public class GraphNode
    {
        public GraphNode(string id, int value = 0)
        {
            Id = id;
            Value = Value;
        }

        public GraphNode(GraphNode node)
        {
            if (node == null)
            {
                return;
            }
            Id = node.Id;
            Value = node.Value;
        }

        public string Id { get; }
        public int Value { get; }
    }
}