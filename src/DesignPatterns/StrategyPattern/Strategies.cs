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
    public class DefaultSort 
    {
        
    }

    public class ReverseSort 
    {
        
    }
}
