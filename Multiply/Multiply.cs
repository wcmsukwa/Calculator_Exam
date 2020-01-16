using System;
using Ops;

namespace Multiply
{
    public interface IMultiply
    {
        public dynamic Multiply(dynamic a, dynamic b);
    }

    public class Multiplying : IMultiply

    {
        public dynamic result;

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = Multiplication.Product(a, b);
            return result;
        }
    }
}
