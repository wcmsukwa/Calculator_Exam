using System;

namespace Ops
{
    public class Addition
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Sum(double[] arrayA)
        {
            double c = 0.0;

            foreach (double a in arrayA)
            {
                c = Sum(a, c);
            }

            return c;
        }

        public static int Sum(int[] arrayB)
        {
            int c = 0;

            foreach (int a in arrayB)
            {
                c = Sum(a, c);
            }

            return c;
        }
    }
    
}
