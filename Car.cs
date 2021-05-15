using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Decorator
{
    /// <summary>
    /// Provides the base type for concrete cars and concrete car options
    /// </summary>
    abstract class Car : ICar
    {
        private double _cost = -1;
        private string _desc = "abstract car. ";
        
        #region ICar Members

        public virtual double Cost
        {
            get { return _cost; }
        }

        public virtual string Description
        {
            get { return _desc; }
        }

        #endregion
    }
}
