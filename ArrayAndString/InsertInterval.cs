using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class Interval
    {
        public Interval()
        {
            Start = 0;
            End = 0;
        }

        public Interval(int s, int e)
        {
            Start = s;
            End = e;
        }

        public int Start { get; set; }
        public int End { get; set; }

        public override string ToString()
        {
            return $"[{Start},{End}]";
        }
    }

    public class InsertInterval
    {
        public List<Interval> Insert(List<Interval> intervals, Interval newInterval)
        {
            var result = new List<Interval>();
            foreach (var interval in intervals)
            {
                if (interval.End < newInterval.Start)
                {
                    result.Add(interval);
                }
                else if (interval.Start > newInterval.End)
                {
                    result.Add(newInterval);
                    newInterval = interval;
                }
                else if (interval.End >= newInterval.Start || interval.Start <= newInterval.End)
                {
                    newInterval = new Interval(Math.Min(interval.Start, newInterval.Start),
                        Math.Max(newInterval.End, interval.End));
                }
            }
            result.Add(newInterval);
            return result;
        }
    }
}