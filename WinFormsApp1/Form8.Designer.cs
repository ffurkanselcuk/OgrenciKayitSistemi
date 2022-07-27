namespace WinFormsApp1
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInstructorName = new System.Windows.Forms.Label();
            this.lblInstructorAssignment = new System.Windows.Forms.Label();
            this.cmbInstructorName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(377, 176);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(152, 44);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(121, 23);
            this.cmbCourseName.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(27, 52);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(79, 15);
            this.lblCourseName.TabIndex = 20;
            this.lblCourseName.Text = "Course Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Location = new System.Drawing.Point(273, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInstructorName
            // 
            this.lblInstructorName.AutoSize = true;
            this.lblInstructorName.Location = new System.Drawing.Point(27, 109);
            this.lblInstructorName.Name = "lblInstructorName";
            this.lblInstructorName.Size = new System.Drawing.Size(114, 15);
            this.lblInstructorName.TabIndex = 18;
            this.lblInstructorName.Text = "Name And Surname";
            
            // 
            // lblInstructorAssignment
            // 
            this.lblInstructorAssignment.AutoSize = true;
            this.lblInstructorAssignment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblInstructorAssignment.Location = new System.Drawing.Point(176, 9);
            this.lblInstructorAssignment.Name = "lblInstructorAssignment";
            this.lblInstructorAssignment.Size = new System.Drawing.Size(124, 15);
            this.lblInstructorAssignment.TabIndex = 21;
            this.lblInstructorAssignment.Text = "Instructor Assignment";
            // 
            // cmbInstructorName
            // 
            this.cmbInstructorName.FormattingEnabled = true;
            this.cmbInstructorName.Location = new System.Drawing.Point(152, 101);
            this.cmbInstructorName.Name = "cmbInstructorName";
            this.cmbInstructorName.Size = new System.Drawing.Size(121, 23);
            this.cmbInstructorName.TabIndex = 2;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(483, 221);
            this.Controls.Add(this.cmbInstructorName);
            this.Controls.Add(this.lblInstructorAssignment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblInstructorName);
            this.Name = "Form8";
            this.Text = "Instructor Assignment";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblInstructorName;
        private System.Windows.Forms.Label lblInstructorAssignment;
        private System.Windows.Forms.ComboBox cmbInstructorID;
        private System.Windows.Forms.ComboBox cmbInstructorName;
    }
}