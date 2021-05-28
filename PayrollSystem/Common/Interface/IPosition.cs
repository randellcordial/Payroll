using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Interface
{
    interface IPosition
    {
        string PositionName { get; set; }
        decimal Rate { get; set; }
    }
}
