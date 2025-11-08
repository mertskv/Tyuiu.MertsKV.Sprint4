using Tyuiu.MertsKV.Sprint4.Task3.V23.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5] { { 5, 7, 7, 6, 3 },
                                          { 8, 7, 8, 4, 3 },
                                          { 5, 6, 7, 8, 3 },
                                          { 4, 2, 3, 6, 4 },
                                          { 5, 2, 4, 2, 3 } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int count = ds.Calculate(array);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Количество чётных элементов в массиве = " + count);


            Console.ReadKey();
        }
    }
}
