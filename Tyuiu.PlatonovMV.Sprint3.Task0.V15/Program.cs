using System;
using Tyuiu.PlatonovMV.Sprint3.Task0.V15.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task0.V15
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Спринт #3 | Выполнил: Платонов М.В. | ИСТНб-25-1";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда по формуле:            *");
            Console.WriteLine("* S = ∑(t^k + 2/(k+1)) * sin(t), где k = 1..10, при t = 0.7               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double t = 0.7;
            int start = 1;
            int stop = 10;

            Console.WriteLine($"t = {t}");
            Console.WriteLine($"Начало ряда = {start}");
            Console.WriteLine($"Конец ряда = {stop}");

            var ds = new DataService();
            double result = ds.GetSumSeries(t, start, stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма ряда = {result}");                                    

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
//