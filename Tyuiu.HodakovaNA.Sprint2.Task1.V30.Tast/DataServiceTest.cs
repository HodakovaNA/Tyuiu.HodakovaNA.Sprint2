using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
//но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность
//операций не должна нарушаться), а также арифметических выражений, которая вернет логическую
//последовательность(массив): (True, False, True, True, True, False), при a = 657, b = 874, c = 14, d = 654

using Tyuiu.HodakovaNA.Sprint2.Task1.V30.Lib;

namespace Tyuiu.HodakovaNA.Sprint2.Task1.V30.Tast
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
