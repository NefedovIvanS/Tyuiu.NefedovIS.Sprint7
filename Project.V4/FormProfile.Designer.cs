namespace Project.V4
{
    partial class FormProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanelProfile_NIS = new TableLayoutPanel();
            labelProfile_NIS = new Label();
            splitContainerUpper_NIS = new SplitContainer();
            splitContainerLower_NIS = new SplitContainer();
            dataGridViewBooksToSdat_NIS = new DataGridView();
            dataGridViewReviews_NIS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainerUpper_NIS).BeginInit();
            splitContainerUpper_NIS.Panel1.SuspendLayout();
            splitContainerUpper_NIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerLower_NIS).BeginInit();
            splitContainerLower_NIS.Panel1.SuspendLayout();
            splitContainerLower_NIS.Panel2.SuspendLayout();
            splitContainerLower_NIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksToSdat_NIS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews_NIS).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelProfile_NIS
            // 
            tableLayoutPanelProfile_NIS.ColumnCount = 1;
            tableLayoutPanelProfile_NIS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelProfile_NIS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelProfile_NIS.ImeMode = ImeMode.Off;
            tableLayoutPanelProfile_NIS.Location = new Point(11, 30);
            tableLayoutPanelProfile_NIS.Name = "tableLayoutPanelProfile_NIS";
            tableLayoutPanelProfile_NIS.RowCount = 3;
            tableLayoutPanelProfile_NIS.RowStyles.Add(new RowStyle(SizeType.Percent, 37.97468F));
            tableLayoutPanelProfile_NIS.RowStyles.Add(new RowStyle(SizeType.Percent, 62.02532F));
            tableLayoutPanelProfile_NIS.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelProfile_NIS.Size = new Size(237, 109);
            tableLayoutPanelProfile_NIS.TabIndex = 0;
            // 
            // labelProfile_NIS
            // 
            labelProfile_NIS.AutoSize = true;
            labelProfile_NIS.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelProfile_NIS.Location = new Point(49, 10);
            labelProfile_NIS.Name = "labelProfile_NIS";
            labelProfile_NIS.Size = new Size(145, 15);
            labelProfile_NIS.TabIndex = 1;
            labelProfile_NIS.Text = "Читательские данные";
            // 
            // splitContainerUpper_NIS
            // 
            splitContainerUpper_NIS.BorderStyle = BorderStyle.FixedSingle;
            splitContainerUpper_NIS.IsSplitterFixed = true;
            splitContainerUpper_NIS.Location = new Point(12, 12);
            splitContainerUpper_NIS.Name = "splitContainerUpper_NIS";
            // 
            // splitContainerUpper_NIS.Panel1
            // 
            splitContainerUpper_NIS.Panel1.Controls.Add(tableLayoutPanelProfile_NIS);
            splitContainerUpper_NIS.Panel1.Controls.Add(labelProfile_NIS);
            splitContainerUpper_NIS.Size = new Size(776, 149);
            splitContainerUpper_NIS.SplitterDistance = 258;
            splitContainerUpper_NIS.TabIndex = 2;
            // 
            // splitContainerLower_NIS
            // 
            splitContainerLower_NIS.BorderStyle = BorderStyle.FixedSingle;
            splitContainerLower_NIS.Location = new Point(12, 167);
            splitContainerLower_NIS.Name = "splitContainerLower_NIS";
            // 
            // splitContainerLower_NIS.Panel1
            // 
            splitContainerLower_NIS.Panel1.Controls.Add(dataGridViewBooksToSdat_NIS);
            // 
            // splitContainerLower_NIS.Panel2
            // 
            splitContainerLower_NIS.Panel2.Controls.Add(dataGridViewReviews_NIS);
            splitContainerLower_NIS.Size = new Size(776, 271);
            splitContainerLower_NIS.SplitterDistance = 386;
            splitContainerLower_NIS.TabIndex = 3;
            // 
            // dataGridViewBooksToSdat_NIS
            // 
            dataGridViewBooksToSdat_NIS.AllowUserToAddRows = false;
            dataGridViewBooksToSdat_NIS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooksToSdat_NIS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBooksToSdat_NIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooksToSdat_NIS.Dock = DockStyle.Fill;
            dataGridViewBooksToSdat_NIS.Location = new Point(0, 0);
            dataGridViewBooksToSdat_NIS.Name = "dataGridViewBooksToSdat_NIS";
            dataGridViewBooksToSdat_NIS.ReadOnly = true;
            dataGridViewBooksToSdat_NIS.Size = new Size(384, 269);
            dataGridViewBooksToSdat_NIS.TabIndex = 0;
            // 
            // dataGridViewReviews_NIS
            // 
            dataGridViewReviews_NIS.AllowUserToAddRows = false;
            dataGridViewReviews_NIS.AllowUserToDeleteRows = false;
            dataGridViewReviews_NIS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReviews_NIS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewReviews_NIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReviews_NIS.Dock = DockStyle.Fill;
            dataGridViewReviews_NIS.Location = new Point(0, 0);
            dataGridViewReviews_NIS.Name = "dataGridViewReviews_NIS";
            dataGridViewReviews_NIS.Size = new Size(384, 269);
            dataGridViewReviews_NIS.TabIndex = 0;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainerLower_NIS);
            Controls.Add(splitContainerUpper_NIS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormProfile";
            Text = "Личный кабинет";
            Load += FormProfile_Load;
            splitContainerUpper_NIS.Panel1.ResumeLayout(false);
            splitContainerUpper_NIS.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerUpper_NIS).EndInit();
            splitContainerUpper_NIS.ResumeLayout(false);
            splitContainerLower_NIS.Panel1.ResumeLayout(false);
            splitContainerLower_NIS.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerLower_NIS).EndInit();
            splitContainerLower_NIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksToSdat_NIS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews_NIS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelProfile_NIS;
        private Label labelProfile_NIS;
        private SplitContainer splitContainerUpper_NIS;
        private SplitContainer splitContainerLower_NIS;
        private DataGridView dataGridViewBooksToSdat_NIS;
        private DataGridView dataGridViewReviews_NIS;
    }
}