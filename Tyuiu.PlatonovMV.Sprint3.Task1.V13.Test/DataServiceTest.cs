using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint3.Task1.V13.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            double n = 1.2;
            int start = 1;
            int stop = 7;

            double res = ds.GetMultiplySeries(n, start, stop);
            double expected = 164.845; 
            Assert.AreEqual(expected, res);
        }
    }
}