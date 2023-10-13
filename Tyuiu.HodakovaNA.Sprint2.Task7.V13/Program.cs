using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint2.Task7.V13.Lib;

namespace Tyuiu.HodakovaNA.Sprint2.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
            {

                DataService ds = new DataService();

                Console.Title = "Спринт #2 | Выполнила Ходакова Н.А. | АСОиУб-23-1";
                Console.WriteLine("***************************************************************************************************");
                Console.WriteLine("* Спринт #2                                                                                       *");
                Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
                Console.WriteLine("* Задание #7                                                                                      *");
                Console.WriteLine("* Вариант #13                                                                                     *");
                Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
                Console.WriteLine("***************************************************************************************************");
                Console.WriteLine("* Задание:                                                                                        *");
                Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и         *");
                Console.WriteLine("* вычисляет, находится ли точка с координатами X,Y в заштрихованной области.                     *");
                Console.WriteLine("***************************************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
                Console.WriteLine("***************************************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

                Console.WriteLine("***************************************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
                Console.WriteLine("***************************************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области. ");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области. ");
            }

                Console.ReadKey();
            }
    }
}
