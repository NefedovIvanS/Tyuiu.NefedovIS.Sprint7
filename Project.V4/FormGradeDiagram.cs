using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.NefedovIS.Sprint7.Task0.V4.Lib;

namespace Project.V4
{
    public partial class FormGradeDiagram_NIS : Form
    {
        public FormGradeDiagram_NIS()
        {
            InitializeComponent();
            DataService ds = new DataService();
            string readerNumber = GlobalVariables.ReaderNumber;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Profiles", readerNumber, "reviews.csv");
            string[,] matrix = ds.CsvToMatrix(path);
            string[] grades = ds.CsvGradesToArray(path);
            int[] values = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                values[i] = Convert.ToInt32(grades[i]);
            }

            var groupedValues = values.GroupBy(x => x)
                                      .Select(g => new { Value = g.Key, Count = g.Count() })
                                      .ToList();

            // Настройка диаграммы
            chart1.Series.Clear(); // Очистить предыдущие серии данных
            chart1.ChartAreas.Clear(); // Очистить предыдущие области диаграммы

            // Добавление области диаграммы
            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            // Создание серии для данных
            Series series = new Series("Element Counts " + DateTime.Now.Ticks); // Уникальное имя серии
            series.ChartType = SeriesChartType.Pie; // Тип диаграммы: столбчатая
            series.IsValueShownAsLabel = true; // Показывать значения на диаграмме

            // Добавление данных из массива в серию
            foreach (var item in groupedValues)
            {
                series.Points.AddXY(item.Value, item.Count); // Добавляем значение и его количество
            }

            // Добавление серии в диаграмму
            chart1.Series.Add(series);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
