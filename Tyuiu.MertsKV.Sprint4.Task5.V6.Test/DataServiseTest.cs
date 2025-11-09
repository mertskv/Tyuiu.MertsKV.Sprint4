using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint4.Task5.V6.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            int[,] matrix = new int[5, 5] { { 9, 6, 9, 3, 7 }, 
                                            { 3, 3, 3, 8, 2 }, 
                                            { 2, 1, 3, 5, 2 },
                                            { 6, 2, 3, 2, 5 },
                                            { 4, 5, 6, 9, 5 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 1, 1, 1, 1, 1 }, 
                            { 1, 1, 1, 1, 1 }, 
                            { 1, 1, 1, 1, 1 }, 
                            { 1, 1, 1, 1, 1 },
                            { 1, 1, 1, 1, 1 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
