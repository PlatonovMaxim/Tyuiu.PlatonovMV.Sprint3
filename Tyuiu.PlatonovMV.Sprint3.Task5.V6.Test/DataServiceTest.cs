using Tyuiu.PlatonovMV.Sprint3.Task5.V6.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            double result = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CheckSumIsPositive()
        {
            DataService ds = new DataService();

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            double result = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

            Assert.IsTrue(result != 0);
        }
    }
}