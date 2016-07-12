using System.Collections.Generic;

namespace Syslo
{
    public class GeneralDpKnapsackSolver : IKnapsackSolver
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
                        dpTotalValue[element - 1][capacity] < dpTotalValue[element][capacity - item.Weight] + item.Value)
                    {
                        dpTotalValue[element][capacity] = dpTotalValue[element][capacity - item.Weight] + item.Value;
                        dpSelectedItems[element][capacity] = element;
                    }
                    else
                    {
                        dpTotalValue[element][capacity] = dpTotalValue[element - 1][capacity];
                        dpSelectedItems[element][capacity] = dpSelectedItems[element - 1][capacity];
                    }
                }
            }

            UpdateSelection(items, limit, dpSelectedItems);

            return dpTotalValue[count - 1][limit];
        }

        private void Initialize(int limit, int count)
        {
            dpTotalValue = new int[count][];
            dpSelectedItems = new int[count][];

            for (var item = 0; item < count; item++)
            {
                dpTotalValue[item] = new int[limit + 1];
                dpSelectedItems[item] = new int[limit + 1];

                dpTotalValue[item][0] = 0;
                dpSelectedItems[item][0] = 0;
            }

            for (var capacity = 0; capacity < limit; capacity++)
            {
                dpTotalValue[0][capacity] = 0;
                dpSelectedItems[0][capacity] = 0;
            }

            selection.Clear();
        }

        private void UpdateSelection(IList<Item> items, int limit, int[][] dpSelectedItem)
        {
            var itemNumber = limit;
            while (itemNumber > 0)
            {
                var index = dpSelectedItem[items.Count - 1][itemNumber] + 1;
                if (selection.ContainsKey(items[index].Id))
                {
                    selection[items[index].Id]++;
                }
                else
                {
                    selection[items[index].Id] = 1;
                }

                itemNumber -= index;
            }
        }
    }
}