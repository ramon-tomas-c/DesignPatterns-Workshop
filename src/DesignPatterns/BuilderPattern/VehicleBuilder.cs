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
    public class LowCostVehicleBuilder : Builder

    {
        private Vehicle _product = new Vehicle();

        public override void AddCarInterior()
        {
            _product.Add("InteriorComponents Assembled!");
        }

        public override void AddEngine()
        {
            _product.Add("BuildEngine Assembled!");
        }

        public override void AddWheels()
        {
            _product.Add("BuildWheels Assembled!");
        }

        public override void AddWindows()
        {
            _product.Add("BuildWindows Assembled!");
        }

        public override Vehicle GetVehicle() => _product;
    }
}
