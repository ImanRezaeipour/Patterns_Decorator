using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Decorator
{
    /// <summary>
    /// Provides a concrete implementation of the Alloy Wheels car option.
    /// </summary>
    class OptionAlloyWheels : CarOption
    {
        double _cost = 4564.42;
        string _description = "Alloy Wheels, ";
        Car _car;

        public OptionAlloyWheels(Car car)
        {
            _car = car;
        }

        public override double Cost
        {
            get
            {
                return _car.Cost + _cost;
            }
        }

        public override string Description
        {
            get
            {
                return _car.Description + _description;
            }
        }
    }
}
