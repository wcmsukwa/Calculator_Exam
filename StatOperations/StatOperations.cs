using System;
using System.Collections.Generic;

namespace StatOperations
{
    public class StatOperations
    {
        public static dynamic Mean(dynamic values)
        {

            var sum = Ops.Addition.Sum(values);
            var valueCount = Helpers.Array.Length(values);
            var result = Ops.Division.Quot(sum, valueCount);
            return Helpers.Rounding.RoundToTwoDecimalPlaces(result);
        }

        public static dynamic StandardDeviation(dynamic values)
        {

            //number of data points
            int numberOfDataPoints = Helpers.Array.Length(values);
            double[] dataPointsArray = new double[numberOfDataPoints];
            //step 1 - find the mean
            var mean = Mean(values);
            //step 2 - For each data point, find the square of its distance to the mean
            foreach (dynamic dataPoint in values)
            {
                var distanceToMean = mean - dataPoint;
                var squareDistanceToMean = Ops.Square.Squared(distanceToMean);
                dataPointsArray[--numberOfDataPoints] = squareDistanceToMean;
            }
            //Step 3 - Sum the values from Step 2
            //Step 4 - Divide by the number of data points.
            var resultOfStep3and4 = Mean(dataPointsArray);
            //Step 5 - Take the square root.
            var result = Ops.SquareRoot.Root(resultOfStep3and4);
            return result;
        }

        public static dynamic ZSquare(dynamic dataPoint, dynamic values)
        {

            var mean = Mean(values);
            var standardDeviation = StandardDeviation(values);

            var difference = Ops.Subtraction.Difference(dataPoint, mean);
            var result = Ops.Division.Quot(difference, standardDeviation);
            return result;
        }

        public static dynamic Median(dynamic values)
        {
            var median = 0.0;
            var valueCount = Helpers.Array.Length(values);
            if (valueCount % 2 == 0) //even number
            {
                var step1 = Ops.Division.Quot(valueCount, 2);
                var step2 = Ops.Addition.Sum(step1, 1);
                var step3 = Ops.Addition.Sum(step1, step2);
                median = Ops.Division.Quot(step3, 2);
            }
            else //old number
            {
                var valueCountPlusOne = Ops.Addition.Sum(valueCount, 1);
                median = Ops.Division.Quot(valueCountPlusOne, 2);
            }
            return median;
        }

        public static dynamic Mode(dynamic values)
        {
            int arrayLength = Helpers.Array.Length(values);
            // Insert all elements in hash 
            Dictionary<double, int> hp = new Dictionary<double, int>();

            for (int i = 0; i < arrayLength; i++)
            {
                double key = values[i];
                if (hp.ContainsKey(key))
                {
                    int freq = hp[key];
                    freq++;
                    hp[key] = freq;
                }
                else
                    hp.Add(key, 1);
            }

            // find max frequency. 
            int min_count = 0;
            double result = -1;

            foreach (KeyValuePair<double, int> pair in hp)
            {
                if (min_count < pair.Value)
                {
                    result = pair.Key;
                    min_count = pair.Value;
                }
            }
            return result;

        }
    }
}
