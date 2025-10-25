using Tyuiu.PlatonovMV.Sprint3.Task6.V1.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CheckSmallRange()
        {
            DataService ds = new DataService();

           
            int result = ds.GetSumTheDivisors(12, 12);

            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void CheckPrimeNumber()
        {
            DataService ds = new DataService();

            
            int result = ds.GetSumTheDivisors(13, 13);

            Assert.AreEqual(14, result);
        }
    }
}