using System;
using Ops;

namespace SquareInterface
{
    public interface ISquareInterface
    {
        public dynamic SquareInterface(dynamic a);
    }

    public class Squaring : ISquareInterface

    {
        public dynamic result;

        public dynamic SquareInterface(dynamic a)
        {
            result = Square.Squared(a);
            return result;
        }
    }
}