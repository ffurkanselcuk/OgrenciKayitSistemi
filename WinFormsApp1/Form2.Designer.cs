namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnComletePayment = new System.Windows.Forms.Button();
            this.btnCourseReport = new System.Windows.Forms.Button();
            this.btnInstructorRegistration = new System.Windows.Forms.Button();
            this.btnStudentRegistration = new System.Windows.Forms.Button();
            this.btnCourseCreation = new System.Windows.Forms.Button();
            this.lblCourseRegistrationSystem = new System.Windows.Forms.Label();
            this.btnStudentAssigment = new System.Windows.Forms.Button();
            this.btnInstructorAssignment = new System.Windows.Forms.Button();
            this.btnInstructorReport = new System.Windows.Forms.Button();
            this.btnStudentReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComletePayment
            // 
            this.btnComletePayment.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnComletePayment.Location = new System.Drawing.Point(402, 225);
            this.btnComletePayment.Name = "btnComletePayment";
            this.btnComletePayment.Size = new System.Drawing.Size(88, 57);
            this.btnComletePayment.TabIndex = 6;
            this.btnComletePayment.Text = "C&omplete Payment";
            this.btnComletePayment.UseVisualStyleBackColor = false;
            this.btnComletePayment.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnCourseReport
            // 
            this.btnCourseReport.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCourseReport.Location = new System.Drawing.Point(402, 344);
            this.btnCourseReport.Name = "btnCourseReport";
            this.btnCourseReport.Size = new System.Drawing.Size(88, 57);
            this.btnCourseReport.TabIndex = 9;
            this.btnCourseReport.Text = "Cours&e Report";
            this.btnCourseReport.UseVisualStyleBackColor = false;
            this.btnCourseReport.Click += new System.EventHandler(this.btnPaymentReport_Click);
            // 
            // btnInstructorRegistration
            // 
            this.btnInstructorRegistration.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInstructorRegistration.Location = new System.Drawing.Point(215, 113);
            this.btnInstructorRegistration.Name = "btnInstructorRegistration";
            this.btnInstructorRegistration.Size = new System.Drawing.Size(87, 57);
            this.btnInstructorRegistration.TabIndex = 2;
            this.btnInstructorRegistration.Text = "&Instructor Registration";
            this.btnInstructorRegistration.UseVisualStyleBackColor = false;
            this.btnInstructorRegistration.Click += new System.EventHandler(this.btnTeacherRegistration_Click);
            // 
            // btnStudentRegistration
            // 
            this.btnStudentRegistration.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStudentRegistration.Location = new System.Drawing.Point(35, 113);
            this.btnStudentRegistration.Name = "btnStudentRegistration";
            this.btnStudentRegistration.Size = new System.Drawing.Size(87, 57);
            this.btnStudentRegistration.TabIndex = 1;
            this.btnStudentRegistration.Text = "&Student Registration";
            this.btnStudentRegistration.UseVisualStyleBackColor = false;
            this.btnStudentRegistration.Click += new System.EventHandler(this.btnStudentRegistration_Click);
            // 
            // btnCourseCreation
            // 
            this.btnCourseCreation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCourseCreation.Location = new System.Drawing.Point(402, 113);
            this.btnCourseCreation.Name = "btnCourseCreation";
            this.btnCourseCreation.Size = new System.Drawing.Size(88, 57);
            this.btnCourseCreation.TabIndex = 3;
            this.btnCourseCreation.Text = "&Course Creation";
            this.btnCourseCreation.UseVisualStyleBackColor = false;
            this.btnCourseCreation.Click += new System.EventHandler(this.btnCourseCreation_Click);
            // 
            // lblCourseRegistrationSystem
            // 
            this.lblCourseRegistrationSystem.AutoSize = true;
            this.lblCourseRegistrationSystem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCourseRegistrationSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourseRegistrationSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCourseRegistrationSystem.Location = new System.Drawing.Point(168, 30);
            this.lblCourseRegistrationSystem.Name = "lblCourseRegistrationSystem";
            this.lblCourseRegistrationSystem.Size = new System.Drawing.Size(204, 23);
            this.lblCourseRegistrationSystem.TabIndex = 5;
            this.lblCourseRegistrationSystem.Text = "Course Registration System";
            // 
            // btnStudentAssigment
            // 
            this.btnStudentAssigment.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStudentAssigment.Location = new System.Drawing.Point(214, 225);
            this.btnStudentAssigment.Name = "btnStudentAssigment";
            this.btnStudentAssigment.Size = new System.Drawing.Size(88, 57);
            this.btnStudentAssigment.TabIndex = 5;
            this.btnStudentAssigment.Text = "S&tudent Assignment";
            this.btnStudentAssigment.UseVisualStyleBackColor = false;
            this.btnStudentAssigment.Click += new System.EventHandler(this.btnStudentAssigment_Click);
            // 
            // btnInstructorAssignment
            // 
            this.btnInstructorAssignment.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInstructorAssignment.Location = new System.Drawing.Point(35, 225);
            this.btnInstructorAssignment.Name = "btnInstructorAssignment";
            this.btnInstructorAssignment.Size = new System.Drawing.Size(88, 57);
            this.btnInstructorAssignment.TabIndex = 4;
            this.btnInstructorAssignment.Text = "I&nstructor Assignment";
            this.btnInstructorAssignment.UseVisualStyleBackColor = false;
            this.btnInstructorAssignment.Click += new System.EventHandler(this.btnInstructorAssignment_Click);
            // 
            // btnInstructorReport
            // 
            this.btnInstructorReport.BackColor = System.Drawing.Color.RosyBrown;
            this.btnInstructorReport.Location = new System.Drawing.Point(214, 344);
            this.btnInstructorReport.Name = "btnInstructorReport";
            this.btnInstructorReport.Size = new System.Drawing.Size(88, 57);
            this.btnInstructorReport.TabIndex = 8;
            this.btnInstructorReport.Text = "Inst&ructor Report";
            this.btnInstructorReport.UseVisualStyleBackColor = false;
            this.btnInstructorReport.Click += new System.EventHandler(this.btnInstructorReport_Click);
            // 
            // btnStudentReport
            // 
            this.btnStudentReport.BackColor = System.Drawing.Color.RosyBrown;
            this.btnStudentReport.Location = new System.Drawing.Point(34, 344);
            this.btnStudentReport.Name = "btnStudentReport";
            this.btnStudentReport.Size = new System.Drawing.Size(88, 57);
            this.btnStudentReport.TabIndex = 7;
            this.btnStudentReport.Text = "St&udent Report";
            this.btnStudentReport.UseVisualStyleBackColor = false;
            this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 441);
            this.Controls.Add(this.btnStudentReport);
            this.Controls.Add(this.btnInstructorReport);
            this.Controls.Add(this.btnInstructorAssignment);
            this.Controls.Add(this.btnStudentAssigment);
            this.Controls.Add(this.lblCourseRegistrationSystem);
            this.Controls.Add(this.btnCourseCreation);
            this.Controls.Add(this.btnStudentRegistration);
            this.Controls.Add(this.btnInstructorRegistration);
            this.Controls.Add(this.btnCourseReport);
            this.Controls.Add(this.btnComletePayment);
            this.Name = "Form2";
            this.Text = "Course Registration System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComletePayment;
        private System.Windows.Forms.Button btnCourseReport;
        private System.Windows.Forms.Button btnInstructorRegistration;
        private System.Windows.Forms.Button btnStudentRegistration;
        private System.Windows.Forms.Button btnCourseCreation;
        private System.Windows.Forms.Label lblCourseRegistrationSystem;
        private System.Windows.Forms.Button btnStudentAssigment;
        private System.Windows.Forms.Button btnInstructorAssignment;
        private System.Windows.Forms.Button btnInstructorReport;
        private System.Windows.Forms.Button btnStudentReport;
    }
}