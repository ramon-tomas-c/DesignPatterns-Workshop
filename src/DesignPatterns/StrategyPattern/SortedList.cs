using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    /// <summary>
    /// The Context Class
    /// </summary>
    public class SortedList
    {
        private List<string> _list = new List<string>();

        public void SetSortStrategy()
        {
           
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {  
            // Use strategy

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
