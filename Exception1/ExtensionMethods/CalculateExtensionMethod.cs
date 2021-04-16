using System;
using System.Collections.Generic;
using System.Text;

namespace Exception1
{
    public static class CalculateExtensionMethod
    {
        public static float Division (this int num, int divider)
        {
            return num / divider;
        }

    }
}
