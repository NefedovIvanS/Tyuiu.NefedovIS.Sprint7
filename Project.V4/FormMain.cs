using Tyuiu.NefedovIS.Sprint7.Task0.V4.Lib;

namespace Project.V4
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public string path;
        public string[,] matrix;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonRefreshCSV_NIS_Click(object sender, EventArgs e)
        {
            dataGridView_NIS.Rows.Clear();
            dataGridView_NIS.Columns.Clear();
            string path = @"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint7\Books.csv";
            string[,] matrix = ds.CsvToMatrix(path);
            for (int col = 0; col <= 5; col++)
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint7\Books.csv";
            string[,] matrix = ds.CsvToMatrix(path);
            string input = textBoxArticul_NIS.Text;
            //Проверка на введение артикула
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Пожалуйста, введите артикул книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Пожалуйста, проверьте правильность ввода.\nАртикул содержит только целочисленные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //Поиск названия книги по артикулу
            bool BookFound = false;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 5] == input)
                {
                    //Определение переменных для инфо о книгах
                    string author = matrix[row, 0];
                    string bookname = matrix[row, 1];
                    string year = matrix[row, 2];
                    string publisher = matrix[row, 3];
                    string price = matrix[row, 4];
                    string article = matrix[row, 5];
                    string description = matrix[row, 6];

                    tableLayoutPanel_NIS.Controls.Clear();
                    BookFound = true;
                    //Жёстко создаём текст
                    Label BookName = new Label
                    {
                        Text = bookname,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Anchor = AnchorStyles.None
                    };
                    tableLayoutPanel_NIS.Controls.Add(BookName, 0, 0);

                    Label BookAuthor = new Label
                    {
                        Text = author,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Anchor = AnchorStyles.None
                    };
                    tableLayoutPanel_NIS.Controls.Add(BookAuthor, 1, 0);

                    Label BookYear = new Label
                    {
                        Text = year,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 9),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Anchor = AnchorStyles.None
                    };
                    tableLayoutPanel_NIS.Controls.Add(BookYear, 2, 0);

                    Label BookPublisher = new Label
                    {
                        Text = publisher,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 9),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Anchor = AnchorStyles.None
                    };
                    tableLayoutPanel_NIS.Controls.Add(BookPublisher, 3, 0);

                    Label BookPrice = new Label
                    {
                        Text = price + " руб.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 9),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Anchor = AnchorStyles.None
                    };
                    tableLayoutPanel_NIS.Controls.Add(BookPrice, 4, 0);

                    Label BookDescription = new Label
                    {
                        Text = description,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 9),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Anchor = AnchorStyles.None
                    };
                    tableLayoutPanel_NIS.Controls.Add(BookDescription, 5, 0);

                    // Очистка TextBox после добавления
                    textBoxArticul_NIS.Clear();
                    textBoxArticul_NIS.Focus();
                    return;
                }
            }
            if (!BookFound)
            {
                MessageBox.Show("Книга не найдена. Пожалуйста, проверьте соответсвие введёного артикула.", "Книга не найдена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonTextToPickAndViceVersa_NIS_Click(object sender, EventArgs e)
        {
            if (buttonAbout_NIS.Image == null)
            {
                buttonTextToPickAndViceVersa_NIS.Image = Properties.Resources.report_go;
                buttonRefreshCSV_NIS.Image = Properties.Resources.table_refresh;
                buttonRefreshCSV_NIS.Text = null;
                buttonFindBook_NIS.Image = Properties.Resources.book_link;
                buttonFindBook_NIS.Text = null;
                buttonProfile_NIS.Image = Properties.Resources.vcard;
                buttonProfile_NIS.Text = null;
                buttonAbout_NIS.Image = Properties.Resources.help;
                buttonAbout_NIS.Text = null;

                return;
            }
            else
            {
                buttonTextToPickAndViceVersa_NIS.Image = Properties.Resources.picture_go;
                buttonRefreshCSV_NIS.Image = null;
                buttonRefreshCSV_NIS.Text = "Обновить";
                buttonFindBook_NIS.Image = null;
                buttonFindBook_NIS.Text = "Найти книгу";
                buttonProfile_NIS.Image = null;
                buttonProfile_NIS.Text = "Личный кабинет";
                buttonAbout_NIS.Image = null;
                buttonAbout_NIS.Text = "О приложении";
                return;
            }
        }
    }
}
