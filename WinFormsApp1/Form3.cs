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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FDHC9SG;Initial Catalog=StudentRegistrationSystem;Integrated Security=True"); 
        public Form3()
        {
            InitializeComponent();
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 Back = new Form2();
            Back.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO [Student] values (@Student_Tc,@Student_Name,@Student_Surname,@Student_Email)";
            
            cmd.Parameters.AddWithValue("@Student_Tc", txtStudentTc.Text);
            cmd.Parameters.AddWithValue("@Student_Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Student_Surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@Student_Email", txtEmail.Text);
            
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Student Registered!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            txtEmail.Text = "";
            txtName.Text = "";
            txtStudentTc.Text = "";
            txtSurname.Text = "";
        }

       
    }
}
