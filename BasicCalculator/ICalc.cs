using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface ICalc
    {
        public dynamic Add(dynamic a, dynamic b);

        public dynamic Divide(dynamic a, dynamic b);

        public dynamic Add(dynamic values);
    }
}
