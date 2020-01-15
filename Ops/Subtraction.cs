using System;
using System.Collections.Generic;
using System.Text;

namespace Ops
{
    public class Subtraction
    {
        public static int Difference(int a, int b)
        {
            return a - b;
        }

        public static double Difference(double a, double b)
        {
            return a - b;
        }

        public static double Difference(double[] arrayA)
        {
            double c = 10.0;

            foreach (double a in arrayA)
            {
                c = Difference(c, a);
            }

            return c;
        }

        public static int Difference(int[] arrayB)
        {
            int c = 10;

            foreach (int a in arrayB)
            {
                c = Difference(a, c);
            }

            return c;
        }
    }
}
