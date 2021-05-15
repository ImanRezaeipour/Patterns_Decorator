using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Decorator
{
    /// <summary>
    /// Provides a concrete implementation of the Leather car option.
    /// </summary>
    class OptionLeather : CarOption
    {
        double _cost = 1000;
        string _description = "Leather Seats, ";
        Car _car;

        public OptionLeather(Car car)
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
