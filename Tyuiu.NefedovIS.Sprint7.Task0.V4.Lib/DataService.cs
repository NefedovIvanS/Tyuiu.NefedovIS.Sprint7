using System.IO;

namespace Tyuiu.NefedovIS.Sprint7.Task0.V4.Lib
{
    public class DataService
    {
        public string[,] CsvToMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // Определяем размеры матрицы
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length; // Предполагаем, что разделитель - ";"

            // Создаем двумерный массив
            string[,] matrix = new string[rows, columns]; //Аооаоа)))


            // Заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            return matrix;
        }
    }
}