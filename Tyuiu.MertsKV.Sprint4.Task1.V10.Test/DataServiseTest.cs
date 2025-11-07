using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint4.Task1.V10.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            int[] numsArray = new int[] { 1, 3, 5 };
            Assert.AreEqual(15, ds.Calculate(numsArray));
        }
    }
}
