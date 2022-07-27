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
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FDHC9SG;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
        public Form5()
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
            cmd.CommandText = "INSERT INTO [Course] values (@Course_Name,@Course_Term,@Course_Fee,@Course_Code)";

            
            cmd.Parameters.AddWithValue("@Course_Name", txtCourseName.Text);
            cmd.Parameters.AddWithValue("@Course_Term", cmbTerm.Text);
            cmd.Parameters.AddWithValue("@Course_Fee", txtFee.Text);
            cmd.Parameters.AddWithValue("@Course_Code", txtCourseCode.Text);

            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Course Registered!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            txtCourseCode.Text = "";
            txtCourseName.Text = "";
            cmbTerm.SelectedIndex = -1;
            txtFee.Text = "";
        }
    }
}
