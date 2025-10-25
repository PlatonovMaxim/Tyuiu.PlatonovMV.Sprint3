using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PlatonovMV.Sprint3.Task5.V6.Lib
{
    public class DataService : ISprint3Task5V6
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;

            
            for (int i = startValue1; i <= stopValue1; i++)
            {
               
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += (1.0 / Math.Cos(k)) + 2;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}