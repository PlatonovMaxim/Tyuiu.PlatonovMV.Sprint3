using System;
using Tyuiu.PlatonovMV.Sprint3.Task1.V13.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task1.V13
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Спринт #3 | Выполнил: Платонов М.В. | ИСТНб-25-1";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл while, вычислить произведение ряда по формуле:           *");
            Console.WriteLine("* P = Π( (1 / n^k)^(-1) ), где k = 1..7, при n = 1.2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double n = 1.2;
            int start = 1;
            int stop = 7;

            Console.WriteLine($"n = {n}");
            Console.WriteLine($"Начало ряда = {start}");
            Console.WriteLine($"Конец ряда = {stop}");

            var ds = new DataService();
            double result = ds.GetMultiplySeries(n, start, stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение ряда = {result}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}