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
    public partial class Form9 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FDHC9SG;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }

      


        void list()
        {

            SqlDataAdapter ad = new SqlDataAdapter("GetStudentReport", conn);
            DataTable t = new DataTable();
            ad.Fill(t);
            dataGriev.DataSource = t;

        }
        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 Back = new Form2();
            Back.Show();
            this.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            list();
        }
    }
}
