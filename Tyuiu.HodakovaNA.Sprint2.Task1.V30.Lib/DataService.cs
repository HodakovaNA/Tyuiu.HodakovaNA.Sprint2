using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
//но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность
//операций не должна нарушаться), а также арифметических выражений, которая вернет логическую
//последовательность(массив): (True, False, True, True, True, False), при a = 657, b = 874, c = 14, d = 654

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HodakovaNA.Sprint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            //a = 657, b = 874, c = 14, d = 654

            res[0] = (a > b) | (c < d);
            res[1] = (a != b) & (c > d);
            res[2] = (c <= b) || (a == d);
            res[3] = (a < b) && (c <= d);
            res[4] = !res[1];
            res[5] = (a <= b) ^ (c < d);

            return res; ;
        }
    }
}
