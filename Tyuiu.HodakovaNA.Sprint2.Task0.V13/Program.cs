using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций
//не должна нарушаться) и арифметических выражений, которая вернет логическую
//последовательность(массив): (False, True, False, True, False, True), при x = 1905, y = 475

using Tyuiu.HodakovaNA.Sprint2.Task0.V13.Lib;

namespace Tyuiu.HodakovaNA.Sprint2.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            //Написать программу, которая вычисляет математическое выражение по исходным значениям данных,
            //вводимых пользователем. Ответ округлите до 3 знаков после запятой.

            Console.Title = "Спринт #2 | Выполнила Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #0                                                                                      *");
            Console.WriteLine("* Вариант #13                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций     *");
            Console.WriteLine("* не должна нарушаться) и арифметических выражений, которая вернет логическую                     *");
            Console.WriteLine("* последовательность(массив): (False, True, False, True, False, True), при x = 1905, y = 475      *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            int x = 1905;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("Значение X = " + x);
            Console.WriteLine("Хначение Y = " + y);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            for (int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }    

            Console.ReadKey();

        }
    }
}