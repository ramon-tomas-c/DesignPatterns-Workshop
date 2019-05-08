using System;

namespace ObserverPattern
{
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
        public class Restaurant 
        {

            public Restaurant(string name, double purchaseThreshold)
            {

            }           
        }
    }
}
