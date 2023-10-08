using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint2.Task4.V15.Lib;

namespace Tyuiu.SavenkovaME.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 3.125;
            Assert.AreEqual(wait, res);
        }
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 625;
            double res = ds.Calculate(x, y);
            double wait = 11.016;
            Assert.AreEqual(wait, res);
        }
    }
}
