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
    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FDHC9SG;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 Back = new Form2();
            Back.Show();
            this.Hide();
        }
        

        private void Form6_Load(object sender, EventArgs e)
        {
            list();
        }
        void list()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Course", conn);
            DataTable t = new DataTable();
            ad.Fill(t);
            cmbCourseName.DataSource = t;
            cmbCourseName.DisplayMember = "Course_Name";
            cmbCourseName.ValueMember = "Course_ID";

            SqlDataAdapter ad2 = new SqlDataAdapter("Select Student_ID,Student_Name+ ' ' + Student_Surname as 'Name' from Student ", conn);
            DataTable t2 = new DataTable();
            ad2.Fill(t2);
            cmbStudentName.DataSource = t2;
            cmbStudentName.DisplayMember = "Name";
            cmbStudentName.ValueMember = "Student_ID";




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO [EnrollStudentCourse] values (@Student_ID,@Course_Name)";
            
            cmd.Parameters.AddWithValue("@Student_ID", Int64.Parse(cmbStudentName.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@Course_Name", Int64.Parse(cmbCourseName.SelectedValue.ToString()));



            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Student Assigment Registered!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
           
           
        }

     
    }
    
}
