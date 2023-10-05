using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint2.Task2.V25.Lib;

namespace Tyuiu.HodakovaNA.Sprint2.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            //Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет находится ли точка с координатами X,Y в заштрихованной области.

            Console.Title = "Спринт #2 | Выполнила Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #2                                                                                      *");
            Console.WriteLine("* Вариант #25                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет находится ли *");
            Console.WriteLine("* точка с координатами X,Y в заштрихованной области.                                              *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            int x;
            int y;

            Console.Write("Введите значение переменной X: ");
            x = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите значение переменной Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в запрашиваемой области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в запрашиваемой области");
            }

            Console.ReadKey();

        }
    }
}
