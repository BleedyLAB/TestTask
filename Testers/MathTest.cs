using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using Task.Util;

namespace Testers
{
    [TestClass]
    public class MathTest
    {
        List<double> data = new List<double>() { 12.4, 57.8, 6.2, 71.6, 1.4, 1.0, 124.4, 583.9, 12.4, 71.6 };
        MathImpl _math = new MathImpl();

        [TestMethod]
        public void MedianaTest()
        {

            var result = _math.GetMediana(data, 1);
            double await = 35.1d;
            Assert.AreEqual(await, result);
        }

        [TestMethod]
        public void DispersionTest()
        {

            var result = _math.GetDispersion(data, 1);
            double await = 28148.9d;
            Assert.AreEqual(await, result);
        }

        [TestMethod]
        public void MSDTest()
        {
            var result = _math.GetMSD(data, 1);
            double await = 167.8d;
            Assert.AreEqual(await, result);
        }

        [TestMethod]
        public void ModaTest()
        {
            var result = String.Join("; ", _math.GetModa(data, 2));
            string await = "12,4; 71,6";
            Assert.AreEqual(await, result);
        }
    }
}
