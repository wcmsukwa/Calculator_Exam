using System;

namespace StatisticsCalculator
{
    public class StatisticsCalculator : Calculator,IStatisticsCalculator
    {
        public dynamic Mean(dynamic values)
        {
            result = StatOperations.StatsOperations.Mean(values);
            return result;
        }

        public dynamic StandardDeviation(dynamic values)
        {
            result = StatOperations.StatOperations.StandardDeviation(values);
            return result;
        }

        public dynamic ZSquare(dynamic dataPoint, dynamic values)
        {
            result = StatOperations.StatOperations.ZSquare(dataPoint, values);
            return result;
        }

        public dynamic Median(dynamic values)
        {
            result = StatOperations.StatOperations.Median(values);
            return result;
        }

        public dynamic Mode( dynamic values)
        {
            result = StatOperations.StatOperations.Mode(values);
            return result;
        }
    }
}
