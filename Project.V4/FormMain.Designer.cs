﻿namespace Project.V4
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
            panelButtons_NIS = new Panel();
            buttonRefreshCSV_NIS = new Button();
            panelButtons_NIS.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_NIS
            // 
            panelButtons_NIS.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_NIS.Controls.Add(buttonRefreshCSV_NIS);
            panelButtons_NIS.Dock = DockStyle.Top;
            panelButtons_NIS.Location = new Point(0, 0);
            panelButtons_NIS.Name = "panelButtons_NIS";
            panelButtons_NIS.Size = new Size(1021, 68);
            panelButtons_NIS.TabIndex = 1;
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
            buttonRefreshCSV_NIS.UseVisualStyleBackColor = true;
            buttonRefreshCSV_NIS.Click += buttonRefreshCSV_NIS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 569);
            Controls.Add(panelButtons_NIS);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            panelButtons_NIS.ResumeLayout(false);
            panelButtons_NIS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelButtons_NIS;
        private Button buttonRefreshCSV_NIS;
    }
}
