using System.Collections.Generic;

namespace Syslo
{
    public interface IKnapsackSolver
    {
        IDictionary<string, int> Selection { get; }
        int GetMax(List<Item> items, int limit);
    }
}