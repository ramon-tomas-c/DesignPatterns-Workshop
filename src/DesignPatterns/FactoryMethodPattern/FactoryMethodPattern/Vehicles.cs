using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    /// <summary>
    /// Vehicle abstract class
    /// </summary>
    public abstract class Vehicle
    {
        public abstract void DeliverProducts();
    }

    /// <summary>
    /// Concrete vehicle
    /// </summary>
    public class Truck : Vehicle
    {
        public override void DeliverProducts()
        {
            Console.WriteLine("Products delivered by truck");
        }
    }

    public class Motorbike : Vehicle
    {
        public override void DeliverProducts()
        {
            Console.WriteLine("Products delivered by motorbike");
        }
    }

    public class Ship : Vehicle
    {
        public override void DeliverProducts()
        {
            Console.WriteLine("Products delivered by ship");
        }
    }
}
