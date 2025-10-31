using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PlatonovMV.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++) 
            {
                double znam = 2 - 2 * x;

                if (znam == 0)
                {
                    res[count] = 0;
                    count++;
                    continue;
                }
                //F(x) = cos(x) + sin(x)/(2-2x) - 4x на диапазоне [-5; 5]  
                double y = Math.Cos(x) + Math.Sin(x) / znam - 4 * x;
                res[count] = Math.Round(y, 2);
                count++;
            }

            return res;
        }
    }
}
//