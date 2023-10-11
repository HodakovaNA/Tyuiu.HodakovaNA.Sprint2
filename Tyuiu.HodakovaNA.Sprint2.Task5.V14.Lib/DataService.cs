using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HodakovaNA.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string res;

            k = k % 7;
          
            switch (k)
            {
                case 1:
                    res = "Понедельник";
                    d = 1;
                    break;
                case 2:
                    res = "Вторник";
                    d = 2;
                    break;
                case 3:
                    res = "Среда";
                    d = 3;
                    break;
                case 4:
                    res = "Четверг";
                    d = 4; 
                    break;
                case 5:
                    res = "Пятница";
                    d = 5;
                    break;
                case 6:
                    res = "Суббота";
                    d = 6;
                    break;
                case 0:
                    res = "Воскресенье";
                    d = 0;
                    break;
                default:
                    res = "Нет такого дня";
                    d = -1;
                    break;
            }

            return res;
        }
    }
}
