using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// Builder Abstract class
    /// </summary>
    public abstract class Builder
    {
        public abstract void AddWheels();
        public abstract void AddEngine();
        public abstract void AddWindows();
        public abstract void AddCarInterior();
        public abstract Vehicle GetVehicle();

    }

    /// <summary>
    /// The ConcreteBuilder class
    /// </summary>
    public class LowCostVehicleBuilder

    {
        private Vehicle _product = new Vehicle();       
    }
}
