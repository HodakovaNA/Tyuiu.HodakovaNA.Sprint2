using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint2.Task1.V30.Lib;

namespace Tyuiu.HodakovaNA.Sprint2.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            //Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
            //но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность
            //операций не должна нарушаться), а также арифметических выражений, которая вернет логическую
            //последовательность(массив): (True, False, True, True, True, False), при a = 657, b = 874, c = 14, d = 654

            Console.Title = "Спринт #2 | Выполнила Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #1                                                                                      *");
            Console.WriteLine("* Вариант #30                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно        *");
            Console.WriteLine("* чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,    *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также арифметических выражений, которая    *");
            Console.WriteLine("* вернет логическую последовательность(массив): (True, False, True, True, True, False),           *");
            Console.WriteLine("* при a = 657, b = 874, c = 14, d = 654                                                           *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();

        }
    }
}
