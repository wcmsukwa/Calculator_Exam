using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ops.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 5;

        private readonly double b = 10;

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(25, Square.Squared(a));
        }

        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(100, Square.Squared(b));
        }
    }
}