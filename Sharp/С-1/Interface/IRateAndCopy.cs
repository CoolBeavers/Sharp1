using System;
using System.Collections.Generic;
using System.Text;

namespace С_1.Interface
{
    interface IRateAndCopy
    {
        double Rating { get; }
        object DeepCopy();
    }
}
