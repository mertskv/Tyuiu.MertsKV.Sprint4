using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MertsKV.Sprint4.Task6.V20.Lib
{
    public class DataServise : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, i => i.Length < 10);
            return mas;
        }
    }
}
