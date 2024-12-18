using Tyuiu.NefedovIS.Sprint7.Task0.V4.Lib;
namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint7\Books.csv";
            string[,] matrix = ds.CsvToMatrix(path);

            // Вывод матрицы
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
