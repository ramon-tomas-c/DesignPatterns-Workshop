using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// Abstract Subject
    /// </summary>
    public abstract class Fruits
    {
        private double _price;
        private List<IRestaurant> _restaurants = new List<IRestaurant>();

        public Fruits(double price)
        {
            _price = price;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;

                    // Notify observers when price changes
                    Notify(); 
                }
            }
        }
    }

    /// <summary>
    /// Concrete subject
    /// </summary>
    public class Apples : Fruits
    {
        public Apples(double price) : base(price) { }
    }
}
