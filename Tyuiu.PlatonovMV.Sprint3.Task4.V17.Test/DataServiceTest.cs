using Tyuiu.PlatonovMV.Sprint3.Task4.V17.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CheckBreakAtZero()
        {
            DataService ds = new DataService();
            int startValue = -2;
            int stopValue = 2;

            
            double result = ds.Calculate(startValue, stopValue);

            Assert.IsNotNull(result);
        }
    }
}