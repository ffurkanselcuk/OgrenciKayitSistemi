﻿namespace WinFormsApp1
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.lblStudentReport = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dataGriev = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriev)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentReport
            // 
            this.lblStudentReport.AutoSize = true;
            this.lblStudentReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStudentReport.Location = new System.Drawing.Point(339, 9);
            this.lblStudentReport.Name = "lblStudentReport";
            this.lblStudentReport.Size = new System.Drawing.Size(86, 15);
            this.lblStudentReport.TabIndex = 25;
            this.lblStudentReport.Text = "Student Report";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(677, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DarkGray;
            this.btnCheck.Location = new System.Drawing.Point(563, 307);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dataGriev
            // 
            this.dataGriev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriev.Location = new System.Drawing.Point(23, 58);
            this.dataGriev.Name = "dataGriev";
            this.dataGriev.RowTemplate.Height = 25;
            this.dataGriev.Size = new System.Drawing.Size(737, 220);
            this.dataGriev.TabIndex = 26;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(808, 391);
            this.Controls.Add(this.dataGriev);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblStudentReport);
            this.Name = "Form9";
            this.Text = "Student Report";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudentReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dataGriev;
    }
}