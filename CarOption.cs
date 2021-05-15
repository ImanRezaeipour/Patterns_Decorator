using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Decorator
{
    /// <summary>
    /// Provides the base type for concrete car options that will be used to decorate concrete cars
    /// </summary>
    abstract class CarOption : Car
    {
        double _cost = -1;
        string _desc = "abstract car option";


        public override string Description
        {
            get { return _desc; }
        }

        public override double Cost
        {
            get { return _cost; }
        }
    }

}
