using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint3.Task2.V11.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSeries()
        {
            DataService ds = new DataService();

            double x = 0.5;
            int start = 1;
            int stop = 15;

            double res = ds.GetSumSeries(x, start, stop);
            double expected = 0.430438; 
            Assert.AreEqual(expected, res);
        }
    }
}