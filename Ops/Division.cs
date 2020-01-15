using System;
using System.Collections.Generic;
using System.Text;

namespace Ops
{
    public class Division
    {
        public static int Quot(int a, int b)
        {
            return a / b;
        }

        public static double Quot(double a, double b)
        {
            return a / b;
        }

        public static double Quot(double[] arrayA)
        {
            double c = arrayA[0];
            foreach (double a in arrayA)
            {
                c = Quot(c, a);
            }
            double d = c / arrayA[0];
            return d;
        }

        public static int Quot(int[] arrayB)
        {
            int c = arrayB[0];
            foreach (int a in arrayB)
            {
                c = Quot(c, a);
            }
            int d = c / arrayB[0];
            return d;
        }
    }
}
