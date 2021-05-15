using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Decorator
{
    /// <summary>
    /// Defines the members necessary for any Car and/or Car option implementation.
    /// </summary>
    interface ICar
    {
        double Cost {get;}
        string Description { get; }
    }
}
