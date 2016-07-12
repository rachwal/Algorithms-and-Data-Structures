using System.Collections.Generic;

namespace Syslo
{
    public class DecisionGreedyKnapsackSolver : IKnapsackSolver
    {
        private readonly Dictionary<string, int> selection = new Dictionary<string, int>();
        public IDictionary<string, int> Selection => selection;

        public int GetMax(List<Item> items, int limit)
        {
            var max = 0;
            selection.Clear();

            items.Sort(new ItemComparer());

            for (var i = 0; i < items.Count; i++)
            {
                var item = items[i];
                if (limit < item.Weight)
                {
                    continue;
                }
                selection[item.Id] = 1;
                limit = limit - item.Weight;
                max = max + item.Value;
            }
            return max;
        }
    }
}