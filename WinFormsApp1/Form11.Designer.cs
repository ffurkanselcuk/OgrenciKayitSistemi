namespace WinFormsApp1
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.lblInstructorReport = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.daraGriv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.daraGriv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructorReport
            // 
            this.lblInstructorReport.AutoSize = true;
            this.lblInstructorReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblInstructorReport.Location = new System.Drawing.Point(354, 23);
            this.lblInstructorReport.Name = "lblInstructorReport";
            this.lblInstructorReport.Size = new System.Drawing.Size(82, 15);
            this.lblInstructorReport.TabIndex = 40;
            this.lblInstructorReport.Text = "Course Report";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(659, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DarkGray;
            this.btnCheck.Location = new System.Drawing.Point(545, 362);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // daraGriv
            // 
            this.daraGriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daraGriv.Location = new System.Drawing.Point(46, 80);
            this.daraGriv.Name = "daraGriv";
            this.daraGriv.RowTemplate.Height = 25;
            this.daraGriv.Size = new System.Drawing.Size(699, 248);
            this.daraGriv.TabIndex = 41;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(803, 432);
            this.Controls.Add(this.daraGriv);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblInstructorReport);
            this.Name = "Form11";
            this.Text = "Course Report";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daraGriv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructorReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView daraGriv;
    }
}