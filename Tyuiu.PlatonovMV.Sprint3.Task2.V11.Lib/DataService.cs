using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PlatonovMV.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double result = 0;
            int i = startValue;

            do
            {
                result += 1 / Math.Pow(3 + Math.Pow(value, i), i);
                i++;
            } while (i <= stopValue);

            return Math.Round(result, 6);
        }
    }
}