namespace WinFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lblStudentAssignment = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStudentAssignment
            // 
            this.lblStudentAssignment.AutoSize = true;
            this.lblStudentAssignment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStudentAssignment.Location = new System.Drawing.Point(156, 25);
            this.lblStudentAssignment.Name = "lblStudentAssignment";
            this.lblStudentAssignment.Size = new System.Drawing.Size(114, 15);
            this.lblStudentAssignment.TabIndex = 11;
            this.lblStudentAssignment.Text = "Student Assignment";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Location = new System.Drawing.Point(255, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(27, 177);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(114, 15);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Name And Surname";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(27, 92);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(79, 15);
            this.lblCourseName.TabIndex = 12;
            this.lblCourseName.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(149, 89);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(121, 23);
            this.cmbCourseName.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(356, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(149, 169);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(121, 23);
            this.cmbStudentName.TabIndex = 4;
            
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(443, 262);
            this.Controls.Add(this.cmbStudentName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblStudentAssignment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStudentName);
            this.Name = "Form6";
            this.Text = "Student Assignment";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentAssignment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbStudentName;
    }
}