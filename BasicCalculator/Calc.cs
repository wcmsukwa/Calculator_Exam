using Add;
using Divide;
using Multiply;
using Root;
using SquareInterface;
using Subtract;

namespace BasicCalculator
{
    public class Calc : IAdd, IDivide, IMultiply, IRoot, ISquareInterface, ISubtract
    {
        private Adding add = new Adding();
        private Div divide = new Div();
        private Subtracting subtract = new Subtracting();
        private Multiplying multiply = new Multiplying();
        private Squaring square = new Squaring();
        private Rooting root = new Rooting();
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
            return result;
        }

        public dynamic Add(dynamic values)
        {
            result = add.Add(values);
            return result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = divide.Divide(a, b);
            return result;
        }

        public dynamic Subtract(dynamic a, dynamic b)
        {
            result = subtract.Subtract(a, b);
            return result;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = multiply.Multiply(a, b);
            return result;
        }

        public dynamic SquareInterface(dynamic a)
        {
            result = square.SquareInterface(a);
            return result;
        }

        public dynamic Root(dynamic a)
        {
            result = root.Root(a);
            return result;
        }
    }
}
