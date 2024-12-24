using System.IO;

namespace Tyuiu.NefedovIS.Sprint7.Task0.V4.Lib
{
    public class DataService
    {
        public string[,] CsvToMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns]; //Аооаоа)))

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
        public string[] CsvGradesToArray(string path)
        {

            string[,] matrix = CsvToMatrix(path);
            string[] grades_array = new string[matrix.GetLength(0) - 1];
            int cntr = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                grades_array[cntr++] = matrix[i, 4];
            }
            return grades_array;
        }

        public string[] CsvHoursToArray(string path)
        {

            string[,] matrix = CsvToMatrix(path);
            string[] hours_array = new string[matrix.GetLength(0) - 1];
            int cntr = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                hours_array[cntr++] = matrix[i, 2];
            }
            return hours_array;
        }
    }
}