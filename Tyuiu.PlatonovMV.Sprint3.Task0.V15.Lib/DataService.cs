using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PlatonovMV.Sprint3.Task0.V15.Lib
{
    public class DataService : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                sum += (Math.Pow(value, k) + (2.0 / (k + 1))) * Math.Sin(value);
            }

            return Math.Round(sum, 3); 
        }
    }
}