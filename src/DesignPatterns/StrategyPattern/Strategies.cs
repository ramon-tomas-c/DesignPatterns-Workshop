using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// The Strategy abstract class
    /// </summary>
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    /// <summary>
    /// A Concrete strategy class
    /// </summary>
    public class DefaultSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Sorted list ");
        }
    }

    public class ReverseSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine("ReverseSorted list");
        }
    }
}
