using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint4.Task2.V16.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataServise ds = new DataServise();

            int[] numsArray = { 2, 2, 3, 5, 6, 8, 6, 7, 3, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 21;

            Assert.AreEqual(wait, res);
        }
    }
}
