using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatOperationsTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            double[] a = { 10.45, 20.5, 10, 20.1, 15.5 };
            Assert.AreEqual(15.31, StatOperations.Mean(a));
        }

        [TestMethod()]
        public void MedianTest()
        {
            double[] a = { 10.45, 20.5, 10, 20.1, 15.5 };
            Assert.AreEqual(3, StatOperations.Median(a));
        }


        [TestMethod()]
        public void ModeTest()
        {
            double[] a = { 15.50, 20.5, 10, 20.1, 15.5 };
            Assert.AreEqual(15.5, StatOperations.Mode(a));
        }
    }
}