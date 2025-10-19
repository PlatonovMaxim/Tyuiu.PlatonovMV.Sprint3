using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint3.Task0.V15.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries_Correct()
        {
            var ds = new DataService();
            double t = 0.7;
            double expected = 0;

            for (int k = 1; k <= 10; k++)
            {
                expected += (System.Math.Pow(t, k) + (2.0 / (k + 1))) * System.Math.Sin(t);
            }

            expected = System.Math.Round(expected, 3);

            double result = ds.GetSumSeries(t, 1, 10);

            Assert.AreEqual(expected, result);
        }
    }
}