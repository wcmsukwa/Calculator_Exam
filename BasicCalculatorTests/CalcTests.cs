using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calc calculator = new Calc();

            int c = calculator.Add(1, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);
        }

        [TestMethod()]
        public void DivTest()
        {
            Calc calculator = new Calc();

            int c = calculator.Divide(2, 1);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calculator.result);
        }

        [TestMethod()]
        public void AddIntDoubleTest()
        {
            Calc calculator = new Calc();
            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.result);
        }

        [TestMethod()]
        public void AddArrayDoubleTest()
        {
            Calc calculator = new Calc();
            double a = 1.01;
            double b = 2.00;
            double[] values = { a, b };

            double c = calculator.Add(values);

            Assert.AreEqual(3.01, c);
            Assert.AreEqual(3.01, calculator.result);
        }

        [TestMethod()]
        public void AddArrayIntTest()
        {
            Calc calculator = new Calc();
            int[] values = { 1, 2 };

            int c = calculator.Add(values);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calc calculator = new Calc();

            double c = calculator.Divide(2, 1);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calculator.result);
        }
    }
}