namespace Project.V4
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView_NIS = new DataGridView();
            buttonRefreshCSV_NIS = new Button();
            panelButtons_NIS = new Panel();
            buttonTextToPickAndViceVersa_NIS = new Button();
            buttonProfile_NIS = new Button();
            buttonAbout_NIS = new Button();
            labelArticul_NIS = new Label();
            textBoxArticul_NIS = new TextBox();
            buttonFindBook_NIS = new Button();
            tableLayoutPanel_NIS = new TableLayoutPanel();
            toolTip_NIS = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_NIS).BeginInit();
            panelButtons_NIS.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_NIS
            // 
            dataGridView_NIS.AllowUserToAddRows = false;
            dataGridView_NIS.AllowUserToDeleteRows = false;
            dataGridView_NIS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_NIS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_NIS.BackgroundColor = SystemColors.Control;
            dataGridView_NIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_NIS.Dock = DockStyle.Left;
            dataGridView_NIS.Location = new Point(0, 68);
            dataGridView_NIS.Name = "dataGridView_NIS";
            dataGridView_NIS.ReadOnly = true;
            dataGridView_NIS.Size = new Size(810, 541);
            dataGridView_NIS.TabIndex = 2;
            // 
            // buttonRefreshCSV_NIS
            // 
            buttonRefreshCSV_NIS.AutoSize = true;
            buttonRefreshCSV_NIS.Dock = DockStyle.Left;
            buttonRefreshCSV_NIS.Location = new Point(0, 0);
            buttonRefreshCSV_NIS.Name = "buttonRefreshCSV_NIS";
            buttonRefreshCSV_NIS.Size = new Size(75, 64);
            buttonRefreshCSV_NIS.TabIndex = 0;
            buttonRefreshCSV_NIS.Text = "Обновить";
            toolTip_NIS.SetToolTip(buttonRefreshCSV_NIS, "Обновить ассортимент доступных книг");
            buttonRefreshCSV_NIS.UseVisualStyleBackColor = true;
            buttonRefreshCSV_NIS.Click += buttonRefreshCSV_NIS_Click;
            // 
            // panelButtons_NIS
            // 
            panelButtons_NIS.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_NIS.Controls.Add(buttonTextToPickAndViceVersa_NIS);
            panelButtons_NIS.Controls.Add(buttonProfile_NIS);
            panelButtons_NIS.Controls.Add(buttonAbout_NIS);
            panelButtons_NIS.Controls.Add(labelArticul_NIS);
            panelButtons_NIS.Controls.Add(textBoxArticul_NIS);
            panelButtons_NIS.Controls.Add(buttonFindBook_NIS);
            panelButtons_NIS.Controls.Add(buttonRefreshCSV_NIS);
            panelButtons_NIS.Dock = DockStyle.Top;
            panelButtons_NIS.Location = new Point(0, 0);
            panelButtons_NIS.Name = "panelButtons_NIS";
            panelButtons_NIS.Size = new Size(1232, 68);
            panelButtons_NIS.TabIndex = 1;
            // 
            // buttonTextToPickAndViceVersa_NIS
            // 
            buttonTextToPickAndViceVersa_NIS.Dock = DockStyle.Right;
            buttonTextToPickAndViceVersa_NIS.Image = Properties.Resources.picture_go;
            buttonTextToPickAndViceVersa_NIS.Location = new Point(977, 0);
            buttonTextToPickAndViceVersa_NIS.Name = "buttonTextToPickAndViceVersa_NIS";
            buttonTextToPickAndViceVersa_NIS.Size = new Size(42, 64);
            buttonTextToPickAndViceVersa_NIS.TabIndex = 6;
            toolTip_NIS.SetToolTip(buttonTextToPickAndViceVersa_NIS, "Перейти с текста на пиктограммы и наоборот");
            buttonTextToPickAndViceVersa_NIS.UseVisualStyleBackColor = true;
            buttonTextToPickAndViceVersa_NIS.Click += buttonTextToPickAndViceVersa_NIS_Click;
            // 
            // buttonProfile_NIS
            // 
            buttonProfile_NIS.AutoSize = true;
            buttonProfile_NIS.Dock = DockStyle.Right;
            buttonProfile_NIS.Location = new Point(1019, 0);
            buttonProfile_NIS.Name = "buttonProfile_NIS";
            buttonProfile_NIS.Size = new Size(109, 64);
            buttonProfile_NIS.TabIndex = 5;
            buttonProfile_NIS.Text = "Личный кабинет";
            toolTip_NIS.SetToolTip(buttonProfile_NIS, "Открыть окно личного кабинета");
            buttonProfile_NIS.UseVisualStyleBackColor = true;
            buttonProfile_NIS.Click += buttonProfile_NIS_Click;
            // 
            // buttonAbout_NIS
            // 
            buttonAbout_NIS.AutoSize = true;
            buttonAbout_NIS.Dock = DockStyle.Right;
            buttonAbout_NIS.Location = new Point(1128, 0);
            buttonAbout_NIS.Name = "buttonAbout_NIS";
            buttonAbout_NIS.Size = new Size(100, 64);
            buttonAbout_NIS.TabIndex = 4;
            buttonAbout_NIS.Text = "О приложении";
            toolTip_NIS.SetToolTip(buttonAbout_NIS, "О приложении");
            buttonAbout_NIS.UseVisualStyleBackColor = true;
            buttonAbout_NIS.Click += buttonAbout_NIS_Click;
            // 
            // labelArticul_NIS
            // 
            labelArticul_NIS.AutoSize = true;
            labelArticul_NIS.Location = new Point(168, 13);
            labelArticul_NIS.Name = "labelArticul_NIS";
            labelArticul_NIS.Size = new Size(86, 15);
            labelArticul_NIS.TabIndex = 3;
            labelArticul_NIS.Text = "Ввод артикула";
            // 
            // textBoxArticul_NIS
            // 
            textBoxArticul_NIS.Location = new Point(162, 30);
            textBoxArticul_NIS.Name = "textBoxArticul_NIS";
            textBoxArticul_NIS.Size = new Size(100, 23);
            textBoxArticul_NIS.TabIndex = 2;
            // 
            // buttonFindBook_NIS
            // 
            buttonFindBook_NIS.AutoSize = true;
            buttonFindBook_NIS.Dock = DockStyle.Left;
            buttonFindBook_NIS.Location = new Point(75, 0);
            buttonFindBook_NIS.Name = "buttonFindBook_NIS";
            buttonFindBook_NIS.Size = new Size(85, 64);
            buttonFindBook_NIS.TabIndex = 1;
            buttonFindBook_NIS.Text = "Найти книгу";
            toolTip_NIS.SetToolTip(buttonFindBook_NIS, "Найти книгу по артикулу.\n(Артикул содержит только целочисленные значения. Вводится в поле 'Ввод артикула')");
            buttonFindBook_NIS.UseVisualStyleBackColor = true;
            buttonFindBook_NIS.Click += button1_Click;
            // 
            // tableLayoutPanel_NIS
            // 
            tableLayoutPanel_NIS.ColumnCount = 1;
            tableLayoutPanel_NIS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_NIS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_NIS.Dock = DockStyle.Top;
            tableLayoutPanel_NIS.Location = new Point(810, 68);
            tableLayoutPanel_NIS.Name = "tableLayoutPanel_NIS";
            tableLayoutPanel_NIS.RowCount = 6;
            tableLayoutPanel_NIS.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6393433F));
            tableLayoutPanel_NIS.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3606567F));
            tableLayoutPanel_NIS.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel_NIS.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel_NIS.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel_NIS.RowStyles.Add(new RowStyle(SizeType.Absolute, 331F));
            tableLayoutPanel_NIS.Size = new Size(422, 541);
            tableLayoutPanel_NIS.TabIndex = 3;
            // 
            // toolTip_NIS
            // 
            toolTip_NIS.Popup += toolTip1_Popup;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 609);
            Controls.Add(tableLayoutPanel_NIS);
            Controls.Add(dataGridView_NIS);
            Controls.Add(panelButtons_NIS);
            MinimumSize = new Size(1128, 612);
            Name = "FormMain";
            Text = "Я РАЗЪЕБУ ВЕСЬ МИР И РАЗЪЕБУСЬ ВМЕСТЕ С НИМ";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_NIS).EndInit();
            panelButtons_NIS.ResumeLayout(false);
            panelButtons_NIS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView_NIS;
        private Button buttonRefreshCSV_NIS;
        private Panel panelButtons_NIS;
        private Button buttonFindBook_NIS;
        private Label labelArticul_NIS;
        private TextBox textBoxArticul_NIS;
        private TableLayoutPanel tableLayoutPanel_NIS;
        private Button buttonTextToPickAndViceVersa_NIS;
        private Button buttonProfile_NIS;
        private Button buttonAbout_NIS;
        private ToolTip toolTip_NIS;
    }
}
