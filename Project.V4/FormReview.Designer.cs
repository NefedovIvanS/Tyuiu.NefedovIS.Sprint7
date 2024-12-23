namespace Project.V4
{
    partial class FormReview
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
            richTextBoxReview_NIS = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxReview_NIS
            // 
            richTextBoxReview_NIS.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxReview_NIS.Font = new Font("Segoe UI", 11F);
            richTextBoxReview_NIS.Location = new Point(12, 12);
            richTextBoxReview_NIS.Name = "richTextBoxReview_NIS";
            richTextBoxReview_NIS.ReadOnly = true;
            richTextBoxReview_NIS.Size = new Size(405, 503);
            richTextBoxReview_NIS.TabIndex = 0;
            richTextBoxReview_NIS.Text = "";
            richTextBoxReview_NIS.TextChanged += richTextBoxReview_NIS_TextChanged;
            // 
            // FormReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 527);
            Controls.Add(richTextBoxReview_NIS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormReview";
            Text = "FormReview";
            Load += FormReview_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxReview_NIS;
    }
}