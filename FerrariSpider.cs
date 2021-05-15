using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Decorator
{
    /// <summary>
    /// Provides a concrete implementation of the Ferrri Spider car.
    /// </summary>
    class FerrariSpider : Car
    {
        double _cost = 250000;
        string _description = "Ferrari Spider ";

        public override double Cost
        {
            get
            {
                return _cost;
            }
        }

        public override string Description
        {
            get
            {
                return _description;
            }
        }
    }
}
