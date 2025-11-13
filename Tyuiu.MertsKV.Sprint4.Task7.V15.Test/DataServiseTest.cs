using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint4.Task7.V15.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataServise ds = new DataServise();
            int rows = 4;
            int colums = 2;
            int[,] ints = new int[rows, colums];
            string str = "10293847";
            int res = ds.Calculate(rows, colums, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
