using System;
using System.Collections.Generic;
using System.Text;
using Syslo;
using Syslo.Data_Structures;
using Syslo.Pathfinder;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        private static void TestHuffman()
        {
            var huffman = new Huffman();
            var tree = huffman.BuildTree(new double[] {10, 20, 30, 40, 50, 60, 70, 80, 90});
        }

        private static void TestShortestPath()
        {
            var n0 = new AdjacencyList(new[] {1, 2, 3});
            var n1 = new AdjacencyList(new[] {0, 4, 5});
            var n2 = new AdjacencyList(new[] {0, 5, 6});
            var n3 = new AdjacencyList(new[] {0});
            var n4 = new AdjacencyList(new[] {1, 5});
            var n5 = new AdjacencyList(new[] {1, 2, 4, 7, 8});
            var n6 = new AdjacencyList(new[] {2});
            var n7 = new AdjacencyList(new[] {5});
            var n8 = new AdjacencyList(new[] {5});

            var graph = new[] {n0, n1, n2, n3, n4, n5, n6, n7, n8};

            var shortestPathFinder = new PathfinderDijkstra();
            var start = 7;
            var end = 3;

            var path = shortestPathFinder.Find(start, end, graph);
            if (path.Count == 0)
            {
                Console.WriteLine("No Path");
            }

            var step = end;

            while (step != start)
            {
                Console.WriteLine(step);
                step = path[step];
            }

            Console.WriteLine(start);

            Console.WriteLine();
        }

        private static void TestKnapsack()
        {
            var items = new List<Item>
            {
                new Item {Id = "a", Value = 6, Weight = 6},
                new Item {Id = "b", Value = 4, Weight = 2},
                new Item {Id = "c", Value = 5, Weight = 3},
                new Item {Id = "d", Value = 7, Weight = 2},
                new Item {Id = "e", Value = 10, Weight = 3},
                new Item {Id = "f", Value = 2, Weight = 1}
            };

            var greedyDecisionKnapsack = new DecisionGreedyKnapsackSolver();
            Console.WriteLine($"GreedyDecision | total weight: {greedyDecisionKnapsack.GetMax(items, 10)}");

            var dpDecisionKnapsack = new DecisionDpKnapsackSolver();
            Console.WriteLine($"DpDecision | total weight: {dpDecisionKnapsack.GetMax(items, 10)}");

            var greedyGeneralKnapsack = new GeneralGreedyKnapsackSolver();
            Console.WriteLine($"GreedyGeneral | total weight: {greedyGeneralKnapsack.GetMax(items, 23)}");

            var dpGeneralKnapsack = new GeneralDpKnapsackSolver();
            Console.WriteLine($"DpGeneral | total weight: {dpGeneralKnapsack.GetMax(items, 23)}");

            Console.WriteLine();
        }

        private static void TestBucketSort()
        {
            var sort = new BucketSort();

            var a = new ListNode(1);
            var b = new ListNode(1, a);
            var c = new ListNode(1, b);
            var d = new ListNode(1, c);
            var e = new ListNode(1, d);
            var f = new ListNode(1, e);
            var g = new ListNode(1, f);

            var list = new List<ListNode> {a, g, e, f, b, d, c};

            var sortedList = sort.Sort(new Queue<ListNode>(list));

            var sb = new StringBuilder();

            foreach (var item in sortedList)
            {
                sb.Clear();
                var digit = item;
                while (digit != null)
                {
                    sb.Append($"{digit.Value}");
                    digit = digit.Next;
                }
                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine();
        }
    }
}