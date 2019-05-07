using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// The Director class
    /// </summary>
    public class VehicleFactory
    {
        // Builder uses a complex series of steps
        public void Build(Builder builder)
        {
            builder.AddEngine();
            builder.AddWheels();
            builder.AddWindows();
            builder.AddCarInterior();
        }
    }
}
