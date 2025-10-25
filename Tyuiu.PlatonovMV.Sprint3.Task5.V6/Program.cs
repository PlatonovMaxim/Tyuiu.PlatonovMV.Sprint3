using Tyuiu.PlatonovMV.Sprint3.Task5.V6.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Платонов М. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму двойного ряда по формуле:                               *");
            Console.WriteLine("*   3   10                                                                *");
            Console.WriteLine("*   Σ   Σ  (1/cos(k) + 2)                                                 *");
            Console.WriteLine("*  i=1 k=1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue1 = 1;  
            int stopValue1 = 3;   
            int startValue2 = 1;  //
            int stopValue2 = 10;  

            Console.WriteLine($"Переменная i: от {startValue1} до {stopValue1}");
            Console.WriteLine($"Переменная k: от {startValue2} до {stopValue2}");
            Console.WriteLine("Формула: Σ Σ (1/cos(k) + 2)");

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма двойного ряда: {result}");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}