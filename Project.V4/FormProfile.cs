﻿using System;
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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            string num = "100001";
            string profile_path = @$"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint7\Profiles\{num}\profile_data.csv";
            string[,] profile_data_matrix = ds.CsvToMatrix(profile_path);
            string books_path = @$"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint7\Profiles\{num}\books_history.csv";
            string[,] books_history_matrix = ds.CsvToMatrix(books_path);
            string number = profile_data_matrix[1, 0];
            string name = profile_data_matrix[1, 1];
            string phone = profile_data_matrix[1, 2];
            //История взятых книг
            dataGridViewBooksToSdat_NIS.Rows.Clear();
            dataGridViewBooksToSdat_NIS.Columns.Clear();
            for (int col = 0; col <= 3; col++)
            {
                dataGridViewBooksToSdat_NIS.Columns.Add($"Column{col}", books_history_matrix[0, col]);
            }
            
            dataGridViewBooksToSdat_NIS.Columns[0].Width = 175;
            
            for (int row = 1; row < books_history_matrix.GetLength(0); row++)
            {
                string[] rowData = new string[books_history_matrix.GetLength(1)];
                for (int col = 0; col < books_history_matrix.GetLength(1); col++)
                {
                    rowData[col] = books_history_matrix[row, col];
                }
                dataGridViewBooksToSdat_NIS.Rows.Add(rowData);
            }

            //Поле с информацией пользователя
            Label Number = new Label
            {
                Text = "№ билета: " + number,
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleLeft,
                Anchor = AnchorStyles.Left
            };
            tableLayoutPanelProfile_NIS.Controls.Add(Number, 0, 0);

            Label Name = new Label
            {
                Text = "ФИО: " + name,
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleLeft,
                Anchor = AnchorStyles.Left
            };
            tableLayoutPanelProfile_NIS.Controls.Add(Name, 1, 0);

            Label Phone = new Label
            {
                Text = "Номер тел.: " + phone,
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleLeft,
                Anchor = AnchorStyles.Left
            };
            tableLayoutPanelProfile_NIS.Controls.Add(Phone, 2, 0);
            //Обзоры
            string reviews_path = @$"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint7\Profiles\{num}\reviews.csv";
            string[,] reviews_matrix = ds.CsvToMatrix(reviews_path);
            if (reviews_matrix[1, 0] != null)
            {
                MessageBox.Show("a", "a", MessageBoxButtons.OK, MessageBoxIcon.Error );
                for (int col = 0; col <= 4; col++)
                {
                    dataGridViewReviews_NIS.Columns.Add($"Column{col}", reviews_matrix[0, col]);
                }

                dataGridViewReviews_NIS.Columns[0].Width = 10;

                for (int row = 1; row < reviews_matrix.GetLength(0); row++)
                {
                    string[] rowData = new string[reviews_matrix.GetLength(1)];
                    for (int col = 0; col < reviews_matrix.GetLength(1); col++)
                    {
                        rowData[col] = reviews_matrix[row, col];
                    }
                    dataGridViewReviews_NIS.Rows.Add(rowData);
                }
            }
            else
            {
                MessageBox.Show("s", "s", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}