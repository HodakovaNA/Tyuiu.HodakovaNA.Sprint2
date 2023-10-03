using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций
//не должна нарушаться) и арифметических выражений, которая вернет логическую
//последовательность(массив): (False, True, False, True, False, True), при x = 1905, y = 475

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HodakovaNA.Sprint2.Task0.V13.Lib
{
    public class DataService : ISprint2Task0V13
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[]res = new bool[6];

            res[0] = x - 1000 == y; //f
            res[1] = x != y;//t
            res[2] = x - 1000 < y;  //f
            res[3] = x > y; //t
            res[4] = x - 1000 <= y; //f
            res[5] = x >= y;//t

            return res;
        }
    }
}
