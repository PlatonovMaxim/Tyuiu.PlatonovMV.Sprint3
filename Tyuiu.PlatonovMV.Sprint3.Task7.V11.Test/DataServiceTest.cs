using Tyuiu.PlatonovMV.Sprint3.Task7.V11.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;

            double[] res = ds.GetMassFunction(start, stop);

            Assert.AreEqual(11, res.Length);
        }
    }
}