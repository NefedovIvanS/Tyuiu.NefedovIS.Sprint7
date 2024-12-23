using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NefedovIS.Sprint7.Task0.V4.Lib;

namespace Project.V4
{
    public partial class FormReview : Form
    {
        private FormProfile profile;

        public FormReview(FormProfile profile)
        {
            InitializeComponent();
            this.profile = profile; // Инициализируем поле
        }

        private void FormReview_Load(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            if (profile != null)
            {
                string value = profile.textBoxReviewNumber_NIS.Text;
                string readerNumber = profile.labelReaderNumTech_NIS.Text;
                string path = @$"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint7\Profiles\{readerNumber}\reviews.csv";
                string[,] reviews_matrix = ds.CsvToMatrix(path);
                string bookName = "-";
                string reviewText = "Отзыв не был найден. Пожалуйста, проверьте индекс отзыва.";
                for (int i = 0; i < reviews_matrix.GetLength(0); i++)
                {
                    if (reviews_matrix[i, 0] == value)
                    {
                        bookName = reviews_matrix[i, 1];
                        reviewText = reviews_matrix[i, 3];
                        break;
                    }
                }
                this.Text = bookName;
                richTextBoxReview_NIS.Text = reviewText;
            }
            else
            {
                MessageBox.Show("Профиль не инициализирован!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBoxReview_NIS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
