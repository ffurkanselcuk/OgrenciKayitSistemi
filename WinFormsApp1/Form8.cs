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
    public partial class Form8 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FDHC9SG;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 Back = new Form2();
            Back.Show();
            this.Hide();
        }

     

        private void Form8_Load(object sender, EventArgs e)
        {
            
            list();
        }
        void list()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Course",conn);
            DataTable t = new DataTable();
            ad.Fill(t);
            cmbCourseName.DataSource = t;
            cmbCourseName.DisplayMember = "Course_Name";
            cmbCourseName.ValueMember = "Course_ID";

            SqlDataAdapter ad2 = new SqlDataAdapter("Select Instructor_ID,Instructor_Name+ ' ' + Instructor_Surname as 'Name' from Instructor ", conn);
            DataTable t2 = new DataTable();
            ad2.Fill(t2);
            cmbInstructorName.DataSource = t2;
            cmbInstructorName.DisplayMember = "Name";
            cmbInstructorName.ValueMember = "Instructor_ID";




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO [EnrollInstructorCourse] values (@Instructor_ID,@Course_Name)";
        
            cmd.Parameters.AddWithValue("@Instructor_ID", Int64.Parse(cmbInstructorName.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@Course_Name", Int64.Parse(cmbCourseName.SelectedValue.ToString()));



            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Instructor Assigment Registered!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();


        }
    }
    
}
