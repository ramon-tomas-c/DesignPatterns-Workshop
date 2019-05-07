using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    // Concrete Creator
    public class RoadLogistics : Logistics
    {
        // Factory Method implementation
        public override void CreateTransport()
        {
            vehicleList.Add(new Truck());
            vehicleList.Add(new Motorbike());
        }
    }
}
