using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ops.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 10;
        private readonly int b = 2;

        private readonly double c = 10.5;
        private readonly double d = 5;

        private readonly double[] arrayA = { 10, 5, 2.5 };
        private readonly double[] arrayB = { 10, 5, 4 };

        [TestMethod()]
        public void QuotTest()
        {
            Assert.AreEqual(5, Division.Quot(a, b));
        }

        [TestMethod()]
        public void QuotDoubleTest()
        {
            Assert.AreEqual(2.1, Division.Quot(c, d));
        }

        [TestMethod()]
        public void QuotDoubleArrayTest()
        {
            Assert.AreEqual(0.008, Division.Quot(arrayA));
        }

        [TestMethod()]
        public void QuotIntArrayTest()
        {
            Assert.AreEqual(0.005, Division.Quot(arrayB));
        }

        /* [TestMethod()]
         public void DivByZeroTest()
         {
             Assert.ThrowsException<DivideByZeroException>(() => Division.Quot(a, c));
         }
         */
    }
}