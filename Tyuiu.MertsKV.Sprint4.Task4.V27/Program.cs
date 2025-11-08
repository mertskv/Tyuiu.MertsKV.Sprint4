using Tyuiu.MertsKV.Sprint4.Task4.V27.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количевство строк матрицы: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количевство столбцов матрицы: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i + 1}, {j + 1} элемент матрицы: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумму нечетных элементов массива: {ds.Calculate(mtrx)}");

            Console.ReadKey();
        }
    }
}
