using System;
using Ops;

namespace Divide
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b);
    }

    public class Div : IDivide
    {
        public dynamic result;

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = Division.Quot(a, b);
            return result;
        }
    }
}
