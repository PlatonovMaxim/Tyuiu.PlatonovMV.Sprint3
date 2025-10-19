using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PlatonovMV.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                result *= Math.Pow(value, k);
                k++;
            }

            return Math.Round(result, 3);
        }
    }
}