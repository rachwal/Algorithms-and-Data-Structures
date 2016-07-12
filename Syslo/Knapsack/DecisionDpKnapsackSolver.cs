using System.Collections.Generic;

namespace Syslo
{
    public class DecisionDpKnapsackSolver : IKnapsackSolver
    {
        private readonly Dictionary<string, int> selection = new Dictionary<string, int>();
        private int[][] dpSelectedItems;

        private int[][] dpTotalValue;

        public IDictionary<string, int> Selection => selection;

        public int GetMax(List<Item> items, int limit)
        {
            var count = items.Count;

            Initialize(limit, count);

            for (var element = 1; element < count; element++)
            {
                var item = items[element - 1];
                for (var capacity = 1; capacity <= limit; capacity++)
                {
                    if (capacity >= item.Weight &&
                        dpTotalValue[element - 1][capacity] <
                        dpTotalValue[element - 1][capacity - item.Weight] + item.Value)
                    {
                        dpTotalValue[element][capacity] = dpTotalValue[element - 1][capacity - item.Weight] + item.Value;
                        dpSelectedItems[element][capacity] = 1;
                    }
                    else
                    {
                        dpTotalValue[element][capacity] = dpTotalValue[element - 1][capacity];
                        dpSelectedItems[element][capacity] = 0;
                    }
                }
            }

            return dpTotalValue[count - 1][limit];
        }

        private void Initialize(int limit, int count)
        {
            dpTotalValue = new int[count][];
            dpSelectedItems = new int[count][];

            for (var element = 0; element < count; element++)
            {
                dpTotalValue[element] = new int[limit + 1];
                dpSelectedItems[element] = new int[limit + 1];

                dpTotalValue[element][0] = 0;
                dpSelectedItems[element][0] = 0;
            }

            for (var capacity = 0; capacity <= limit; capacity++)
            {
                dpTotalValue[0][capacity] = 0;
                dpSelectedItems[0][capacity] = 0;
            }

            selection.Clear();
        }
    }
}