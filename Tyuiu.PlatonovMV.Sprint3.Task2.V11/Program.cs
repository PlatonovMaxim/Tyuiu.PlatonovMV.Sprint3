using System;
using Tyuiu.PlatonovMV.Sprint3.Task2.V11.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task2.V11
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Спринт #3 | Выполнил: Платонов М.В. | ИСТНб-25-1";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл do...while, которая вычисляет        *");
            Console.WriteLine("* сумму ряда по формуле:                                                  *");
            Console.WriteLine("* S = Σ ( (1 / (3 + x^i))^i ), где i = 1..15, при x = 0.5                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 0.5;
            int start = 1;
            int stop = 15;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"Начало ряда = {start}");
            Console.WriteLine($"Конец ряда = {stop}");

            var ds = new DataService();
            double result = ds.GetSumSeries(x, start, stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма ряда = {result}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}