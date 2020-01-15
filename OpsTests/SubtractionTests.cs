using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ops.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 10;
        private readonly int b = 5;

        private readonly double c = 11.5;
        private readonly double d = 6.7;

        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 6.4, 7, 8.7, 9, 10 };
        private readonly int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(5, Subtraction.Difference(a, b));
        }

        [TestMethod()]
        public void DifferenceDoubleTest()
        {
            Assert.AreEqual(4.8, Subtraction.Difference(c, d));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(-41.28, Subtraction.Difference(arrayA));
        }

        [TestMethod()]
        public void DifferenceIntArrayTest()
        {
            Assert.AreEqual(15, Subtraction.Difference(arrayB));
        }
    }
}