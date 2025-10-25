using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PlatonovMV.Sprint3.Task6.V1.Lib
{
    public class DataService : ISprint3Task6V1
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            
            for (int num = startValue; num <= stopValue; num++)
            {
             
                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        totalSum += divisor; 
                    }
                }
            }

            return totalSum;
        }
    }
}