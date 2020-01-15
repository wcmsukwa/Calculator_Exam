using System;
using System.Collections.Generic;
using System.Text;

namespace Ops
{
    public class Multiplication
    {
        public static int Product(int a, int b)
        {
            return a * b;
        }

        public static double Product(double a, double b)
        {
            return a * b;
        }

        public static double Product(double[] arrayA)
        {
            double c = arrayA[0];
            foreach (double a in arrayA)
            {
                c = Product(c, a);
            }
            double d = c * arrayA[0];
            return d;
        }

        public static int Product(int[] arrayB)
        {
            int c = arrayB[0];
            foreach (int a in arrayB)
            {
                c = Product(c, a);
            }
            int d = c * arrayB[0];
            return d;
        }
    }
}
