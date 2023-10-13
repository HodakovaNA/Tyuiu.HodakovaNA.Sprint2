using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint2.Task7.V13.Lib;

namespace Tyuiu.HodakovaNA.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1.5;
            double y = 0;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
