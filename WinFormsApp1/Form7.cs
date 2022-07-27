using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FDHC9SG;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 Back = new Form2();
            Back.Show();
            this.Hide();
        }

        private void lblCompletePayment_Click(object sender, EventArgs e)
        {

        }

        private void lblFee_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbCourseName.Text == "" || cmbStudentName.Text == "")
            {
                MessageBox.Show("This field cannot be left blank!");
            }
            else
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("Insert into Payment values (@p1,@p2,@p3,@p4)", conn);
                komut.Parameters.AddWithValue("@p2", cmbStudentName.SelectedValue);
                komut.Parameters.AddWithValue("@p3", cmbCourseName.SelectedValue);
                komut.Parameters.AddWithValue("@p1", decimal.Parse(lblTotal.Text.Replace("₺", "")));
                komut.Parameters.AddWithValue("@p4", true);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Payment Successful!");

            }
        }
      
        private void Form7_Load(object sender, EventArgs e)
        {
            Liste();
        }
        void Liste()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select Course.Course_Name as 'Course', Course.Course_ID as 'CourseID' from EnrollStudentCourse inner join Course on Course.Course_ID = EnrollStudentCourse.Course_ID", conn);
            DataTable t = new DataTable();
            ad.Fill(t);
            cmbCourseName.DataSource = t;
            cmbCourseName.DisplayMember = "Course";
            cmbCourseName.ValueMember = "CourseID";

            SqlDataAdapter ad2 = new SqlDataAdapter("Select DISTINCT(Student.Student_Name) + ' ' + Student.Student_Surname AS 'Student',Student.Student_ID as 'StudentID' from EnrollStudentCourse inner join Student on Student.Student_ID = EnrollStudentCourse.Student_ID", conn);
            ad2.SelectCommand.Parameters.AddWithValue("@p1", cmbCourseName.SelectedValue);
            DataTable t2 = new DataTable();
            ad2.Fill(t2);
            cmbStudentName.DataSource = t2;
            cmbStudentName.DisplayMember = "Student";
            cmbStudentName.ValueMember = "StudentID";



        }

        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdnBtn_CheckedChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Select Course_Fee from Course where Course_ID=@p1", conn);
            komut.Parameters.AddWithValue("@p1", cmbCourseName.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblTotal.Text = dr[0].ToString() + "₺";
            }
            dr.Close();
            conn.Close();
        }
    }
}
