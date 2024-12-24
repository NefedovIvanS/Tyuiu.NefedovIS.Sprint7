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
    public partial class FormHoursDiagram_NIS : Form
    {
        public FormHoursDiagram_NIS()
        {
            InitializeComponent();
            DataService ds = new DataService();
            string readerNumber = GlobalVariables.ReaderNumber;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Profiles", readerNumber, "reviews.csv");
            string[,] matrix = ds.CsvToMatrix(path);
            string[] grades = ds.CsvHoursToArray(path);
            int[] values = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                values[i] = Convert.ToInt32(grades[i]);
            }

            var groupedValues = values.GroupBy(x => x)
                                      .Select(g => new { Value = g.Key, Count = g.Count() })
                                      .ToList();

            chart1.Series.Clear(); 
            chart1.ChartAreas.Clear(); 

            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            Series series = new Series("Element Counts " + DateTime.Now.Ticks);
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;

            foreach (var item in groupedValues)
            {
                series.Points.AddXY(item.Value, item.Count);
            }

            chart1.Series.Add(series);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
