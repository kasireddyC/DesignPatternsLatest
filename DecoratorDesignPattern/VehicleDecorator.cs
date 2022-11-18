﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public abstract class VehicleDecorator:IVehicle
    {
        private IVehicle _vehicle;

        public VehicleDecorator(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public string Make
        {
            get { return _vehicle.Make; }
        }
        public string Model
        {
            get { return _vehicle.Model; }
        }
        public double Price
        {
            get { return _vehicle.Price; }
        }
    }
}
