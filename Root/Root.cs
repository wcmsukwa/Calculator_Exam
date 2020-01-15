using System;
using Ops;

namespace Root
{
    public interface IRoot
    {
        public dynamic Root(dynamic a);
    }

    public class Rooting : IRoot

    {
        public dynamic result;

        public dynamic Root(dynamic a)
        {
            result = SquareRoot.Root(a);
            return result;
        }
    }
}