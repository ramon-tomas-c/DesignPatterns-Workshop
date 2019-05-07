using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
    public abstract class Logistics
    {
        public List<Vehicle> vehicleList = new List<Vehicle>();

        // Constructor calls abstract Factory method
        public Logistics()
        {
            this.CreateTransport();
        }

        // Factory Method
        public abstract void CreateTransport();
    }
}
