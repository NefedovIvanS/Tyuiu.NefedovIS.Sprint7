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
            groupBox_NIS = new GroupBox();
            textBox_NIS = new TextBox();
            groupBox_NIS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_NIS
            // 
            groupBox_NIS.Controls.Add(textBox_NIS);
            groupBox_NIS.Location = new Point(2, 164);
            groupBox_NIS.Name = "groupBox_NIS";
            groupBox_NIS.Size = new Size(329, 163);
            groupBox_NIS.TabIndex = 0;
            groupBox_NIS.TabStop = false;
            groupBox_NIS.Text = "groupBox1";
            groupBox_NIS.Enter += groupBox1_Enter;
            // 
            // textBox_NIS
            // 
            textBox_NIS.BorderStyle = BorderStyle.None;
            textBox_NIS.Location = new Point(128, 22);
            textBox_NIS.Multiline = true;
            textBox_NIS.Name = "textBox_NIS";
            textBox_NIS.ReadOnly = true;
            textBox_NIS.ScrollBars = ScrollBars.Vertical;
            textBox_NIS.Size = new Size(103, 91);
            textBox_NIS.TabIndex = 0;
            textBox_NIS.Text = "Есть .csv с книгами, сделай вывод в DataGrid";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 569);
            Controls.Add(groupBox_NIS);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBox_NIS.ResumeLayout(false);
            groupBox_NIS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_NIS;
        private TextBox textBox_NIS;
    }
}
