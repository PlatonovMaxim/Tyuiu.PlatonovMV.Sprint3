using System;
using Tyuiu.PlatonovMV.Sprint3.Task3.V21.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task3.V21
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Спринт #3 | Выполнил: Платонов М.В. | ИСТНб-25-1";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach, заменить цифры на букву 'e' в строке:           *");
            Console.WriteLine("* f3g5ht g4j 34kg4                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string input = "f3g5ht g4j 34kg4";
            char replaceChar = 'e';
            Console.WriteLine($"Исходная строка: {input}");
            Console.WriteLine($"Символ для замены: {replaceChar}");

            DataService ds = new DataService();
            string result = ds.ReplaceNumOnChar(input, replaceChar);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Новая строка: {result}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}