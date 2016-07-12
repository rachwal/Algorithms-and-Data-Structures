using System.Collections.Generic;

namespace Syslo
{
    public class GeneralGreedyKnapsackSolver : IKnapsackSolver
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
                var count = limit/item.Weight;

                if (count == 0)
                {
                    continue;
                }

                selection[item.Id] = count;
                limit = limit - selection[item.Id]*item.Weight;
                max = max + item.Value*selection[item.Id];
            }
            return max;
        }
    }
}