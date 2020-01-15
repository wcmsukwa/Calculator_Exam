using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator
{
    public interface IStatisticsCalculator
    {
        public dynamic Mean(dynamic values);

        public dynamic StandardDeviation(dynamic values);

        public dynamic ZSquare(dynamic dataPoint, dynamic values);

        public dynamic Median(dynamic values);

        public dynamic Mode(dynamic values);
    }
}
