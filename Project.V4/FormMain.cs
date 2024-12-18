using Tyuiu.NefedovIS.Sprint7.Task0.V4.Lib;

namespace Project.V4
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonRefreshCSV_NIS_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint7\Books.csv";
            string[,] matrix = ds.CsvToMatrix(path);
            dataGridView_NIS.Rows.Clear();
            dataGridView_NIS.Columns.Clear();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                dataGridView_NIS.Columns.Add($"Column{col}", matrix[0, col]);
            }

            dataGridView_NIS.Columns[0].Width = 175;
            dataGridView_NIS.Columns[1].Width = 300;
            dataGridView_NIS.Columns[2].Width = 60;
            dataGridView_NIS.Columns[3].Width = 150;
            dataGridView_NIS.Columns[5].Width = 50;


            // Добавление строк данных (начиная со второй строки, так как первая - заголовки)
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                string[] rowData = new string[matrix.GetLength(1)];
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    rowData[col] = matrix[row, col];
                }
                dataGridView_NIS.Rows.Add(rowData);
            }
        }
    }
}
