using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint4.Task6.V20.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataServise ds = new DataServise();
            string[] mas = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] wait = { "Физика", "Химия", "Биология", "География", "История" };
            string[] res = ds.Calculate(mas);
            CollectionAssert.AreEqual(wait, res);
            

        }
    }
}
