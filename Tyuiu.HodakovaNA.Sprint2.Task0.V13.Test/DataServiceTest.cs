using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций
//не должна нарушаться) и арифметических выражений, которая вернет логическую
//последовательность(массив): (False, True, False, True, False, True), при x = 1905, y = 475

using Tyuiu.HodakovaNA.Sprint2.Task0.V13.Lib;

namespace Tyuiu.HodakovaNA.Sprint2.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1905;
            int y = 475;
            bool[] res = new bool[6]; // 6 сравнений, 6 ответов
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
