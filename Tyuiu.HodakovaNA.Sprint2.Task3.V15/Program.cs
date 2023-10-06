using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint2.Task3.V15.Lib;

//Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else,
//где пользователь вводит значение переменной X с клавиатуры. Округлить полученное значение до трех знаков после запятой

namespace Tyuiu.HodakovaNA.Sprint2.Task3.V15
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
            Console.WriteLine("* Задание #3                                                                                      *");
            Console.WriteLine("* Вариант #15                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных   *");
            Console.WriteLine("* оператор if-else, где пользователь вводит значение переменной X с клавиатуры.                   *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.                                     *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();

        }
    }
}
