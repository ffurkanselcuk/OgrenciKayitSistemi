namespace WinFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblCourseRegistration = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Location = new System.Drawing.Point(261, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(96, 121);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(121, 23);
            this.txtCourseName.TabIndex = 2;
            // 
            // txtTerm
            // 
            this.txtTerm.AutoSize = true;
            this.txtTerm.Location = new System.Drawing.Point(27, 175);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(33, 15);
            this.txtTerm.TabIndex = 6;
            this.txtTerm.Text = "Term";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(12, 129);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(79, 15);
            this.lblCourseName.TabIndex = 5;
            this.lblCourseName.Text = "Course Name";
            // 
            // cmbTerm
            // 
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Items.AddRange(new object[] {
            "Summer",
            "Spring"});
            this.cmbTerm.Location = new System.Drawing.Point(96, 167);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(121, 23);
            this.cmbTerm.TabIndex = 4;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(96, 217);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(121, 23);
            this.txtFee.TabIndex = 5;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(35, 225);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(25, 15);
            this.lblFee.TabIndex = 11;
            this.lblFee.Text = "Fee";
            // 
            // lblCourseRegistration
            // 
            this.lblCourseRegistration.AutoSize = true;
            this.lblCourseRegistration.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCourseRegistration.Location = new System.Drawing.Point(152, 21);
            this.lblCourseRegistration.Name = "lblCourseRegistration";
            this.lblCourseRegistration.Size = new System.Drawing.Size(110, 15);
            this.lblCourseRegistration.TabIndex = 13;
            this.lblCourseRegistration.Text = "Course Registration";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(361, 266);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(12, 79);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(75, 15);
            this.lblCourseCode.TabIndex = 14;
            this.lblCourseCode.Text = "Course Code";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(96, 76);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(121, 23);
            this.txtCourseCode.TabIndex = 1;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(448, 329);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCourseRegistration);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.cmbTerm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblCourseName);
            this.Name = "Form5";
            this.Text = "Course Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label txtTerm;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblCourseRegistration;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
    }
}