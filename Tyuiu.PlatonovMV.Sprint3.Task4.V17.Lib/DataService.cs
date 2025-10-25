using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlatonovMV.Sprint3.Task4.V17.Lib
{
    public class DataService : ISprint3Task4V17
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break; 
                }

                double y = Math.Cos(x) / Math.Sin(x); // y = cos(x)/sin(x) = ctg(x)
                result *= y;
            }

            return Math.Round(result, 3);
        }
    }
}