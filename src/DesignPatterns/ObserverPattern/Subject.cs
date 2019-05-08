using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    using System;
    using System.Collections.Generic;

    namespace ObserverPattern
    {
        /// <summary>
        /// Abstract Subject
        /// </summary>
        public abstract class Fruits
        {

            double _price;

            public Fruits(double price)
            {

            }

            public void Attach(IRestaurant restaurant)
            {

            }

            public void Detach(IRestaurant restaurant)
            {

            }

            public void Notify()
            {
                
            }

            public double Price
            {
                get { return _price; }
                set
                {
                    if (_price != value)
                    {
                        _price = value;
                    }
                }
            }
        }

        /// <summary>
        /// Concrete subject
        /// </summary>
        public class Apples 
        {
            
        }
    }
}
