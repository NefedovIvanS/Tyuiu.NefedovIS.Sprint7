namespace Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            richTextBox_NIS = new RichTextBox();
            richTextDeveloper_NIS = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox_NIS
            // 
            richTextBox_NIS.BorderStyle = BorderStyle.None;
            richTextBox_NIS.Location = new Point(12, 12);
            richTextBox_NIS.Name = "richTextBox_NIS";
            richTextBox_NIS.ReadOnly = true;
            richTextBox_NIS.Size = new Size(357, 215);
            richTextBox_NIS.TabIndex = 0;
            richTextBox_NIS.Text = resources.GetString("richTextBox_NIS.Text");
            richTextBox_NIS.TextChanged += richTextBox_NIS_TextChanged;
            // 
            // richTextDeveloper_NIS
            // 
            richTextDeveloper_NIS.BorderStyle = BorderStyle.FixedSingle;
            richTextDeveloper_NIS.Location = new Point(12, 233);
            richTextDeveloper_NIS.Name = "richTextDeveloper_NIS";
            richTextDeveloper_NIS.ReadOnly = true;
            richTextDeveloper_NIS.Size = new Size(357, 104);
            richTextDeveloper_NIS.TabIndex = 1;
            richTextDeveloper_NIS.Text = "Разработчик: Нефедов И. С. \nгруппа СМАРТб-24-1\n\nПрограмма разработана в рамках изучения C#\n\nТюменский индустриальный универститет (c) 2024";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 345);
            Controls.Add(richTextDeveloper_NIS);
            Controls.Add(richTextBox_NIS);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAbout";
            Text = "О приложении";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_NIS;
        private RichTextBox richTextDeveloper_NIS;
    }
}