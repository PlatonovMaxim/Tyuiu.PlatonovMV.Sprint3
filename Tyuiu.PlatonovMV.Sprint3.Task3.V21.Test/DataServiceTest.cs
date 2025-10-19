using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint3.Task3.V21.Lib;

namespace Tyuiu.PlatonovMV.Sprint3.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string input = "f3g5ht g4j 34kg4";
            char replaceChar = 'e';
            string expected = "fegeht gej eekge"; 

            string actual = ds.ReplaceNumOnChar(input, replaceChar);

            Assert.AreEqual(expected, actual);
        }
    }
}