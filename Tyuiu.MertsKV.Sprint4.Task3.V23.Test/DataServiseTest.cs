using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint4.Task3.V23.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataServise ds = new DataServise();
            int[,] mas2 = new int[5, 5]  { { 5, 7, 7, 6, 3 },
                                          { 8, 7, 8, 4, 3 },
                                          { 5, 6, 7, 8, 3 },
                                          { 4, 2, 3, 6, 4 },
                                          { 5, 2, 4, 2, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 13;
            Assert.AreEqual(res, wait);
        }
    }
}
