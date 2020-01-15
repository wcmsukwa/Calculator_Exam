using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ops.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly double a = 25.0;

        [TestMethod()]
        public void RootTest()
        {
            Assert.AreEqual(5, SquareRoot.Root(a));
        }
    }
}