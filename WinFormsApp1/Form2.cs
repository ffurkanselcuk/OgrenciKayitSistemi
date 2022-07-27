using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTeacherRegistration_Click(object sender, EventArgs e)
        {
            Form4 InstructorRegistration = new Form4();
            InstructorRegistration.Show();
            this.Hide();
        }

        private void btnStudentAssigment_Click(object sender, EventArgs e)
        {
            Form6 StudentAssignment = new Form6();
            StudentAssignment.Show();
            this.Hide();
        }

        private void btnCourseCreation_Click(object sender, EventArgs e)
        {
            Form5 CourseCreation = new Form5();
            CourseCreation.Show();
            this.Hide();
        }

        private void btnStudentRegistration_Click(object sender, EventArgs e)
        {
            Form3 StudentRegistration = new Form3();
            StudentRegistration.Show();
            this.Hide();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            Form7 CompletePayment = new Form7();   
            CompletePayment.Show();
            this.Hide();
        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            Form9 StudentReport = new Form9(); 
            StudentReport.Show();
            this.Hide();
        }

        private void btnInstructorReport_Click(object sender, EventArgs e)
        {
            Form10 InstructorForm = new Form10();
                InstructorForm.Show();
            this.Hide();

        }

        private void btnPaymentReport_Click(object sender, EventArgs e)
        {
            Form11 CourseReport = new Form11();
                CourseReport.Show();
            this.Hide();
        }

        private void btnInstructorAssignment_Click(object sender, EventArgs e)
        {
            Form8 InstructorAssignment = new Form8();   
                InstructorAssignment.Show();
            this.Hide();

        }
    }
}
