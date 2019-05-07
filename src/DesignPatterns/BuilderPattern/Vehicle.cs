using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    /// <summary>
    /// Product Class
    /// </summary>
    public class Vehicle
    {
        private List<string> _components = new List<string>();

        public void Add(string part) => _components.Add(part);

        public void Show()
        {
            _components.ForEach((c) => Console.WriteLine(c));
        }
    }
}
