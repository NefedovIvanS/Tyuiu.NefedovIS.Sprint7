using System;
using Tyuiu.NefedovIS.Sprint7.Task0.V4.Lib;
namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string readerNumber = "100001";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Profiles", readerNumber, "reviews.csv");
            string[,] matrix = ds.CsvToMatrix(path);

            //Вывод матрицы
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\n");
                }
                Console.WriteLine();
            }

        }
    }
}
