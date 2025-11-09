using Tyuiu.MertsKV.Sprint4.Task6.V20.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataServise ds = new DataServise();

            string[] mas = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= mas.Length - 1; i++)
            {
                Console.WriteLine(mas[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(mas);
            for (int i = 0; i < res.GetLength(0); i++)
            {
                Console.WriteLine(res[i]);

            }


            Console.ReadKey();
        }
    }
}
