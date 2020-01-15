using System;
using Ops;

namespace Add
{
    public interface IAdd
    {
        public dynamic Add(dynamic a, dynamic b);
    }

    public class Adding : IAdd

    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public dynamic Add(dynamic values)
        {
            result = Addition.Sum(values);
            return result;
        }
    }
}
