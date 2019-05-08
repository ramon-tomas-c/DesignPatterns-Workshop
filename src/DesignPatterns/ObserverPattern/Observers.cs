using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// Observer interface
    /// </summary>
    public interface IRestaurant
    {
        void Update(Fruits fruit);
    }

    /// <summary>
    /// Concrete observer
    /// </summary>
    public class Restaurant : IRestaurant
    {
        private string _name;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Fruits fruit)
        {
            Console.WriteLine($"Notified {_name} of {fruit.GetType().Name}'s price change to {fruit.Price} per pound.");
            if (fruit.Price < _purchaseThreshold)
            {
                Console.WriteLine($"{_name} wants to buy some {fruit.GetType().Name}");
            }
        }
    }
}
