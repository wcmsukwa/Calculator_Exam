using System;
using Ops;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Subtract(dynamic a, dynamic b);
    }

    public class Subtracting : ISubtract

    {
        public dynamic result;

        public dynamic Subtract(dynamic a, dynamic b)
        {
            result = Subtraction.Difference(a, b);
            return result;
        }
    }
}
