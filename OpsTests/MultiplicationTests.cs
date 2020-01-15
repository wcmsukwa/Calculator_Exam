using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ops.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 10;
        private readonly int b = 12;

        private readonly double c = 15.7;
        private readonly double d = 9.03;

        private readonly double[] arrayA = { 2.5, 1.5, 6, 3 };
        private readonly double[] arrayB = { 2, 4, 8, 3, 9 };

        [TestMethod()]
        public void ProductTest()
        {
            Assert.AreEqual(120, Multiplication.Product(a, b));
        }

        [TestMethod()]
        public void ProductDoubleTest()
        {
            Assert.AreEqual(141.771, Multiplication.Product(c, d));
        }

        [TestMethod()]
        public void ProductDoubleArrayTest()
        {
            Assert.AreEqual(421.875, Multiplication.Product(arrayA));
        }

        [TestMethod()]
        public void ProductIntArrayTest()
        {
            Assert.AreEqual(6912, Multiplication.Product(arrayB));
        }
    }
}