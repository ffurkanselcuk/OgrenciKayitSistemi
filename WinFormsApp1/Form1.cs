using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username or password cannot be empty, please fill in.", "Warning!");
            }
            else
            {
                if(txtUsername.Text == "Furkan" && txtPassword.Text == "Selcuk")
                {
                    Form2 HomePage = new Form2();  
                    HomePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password are not correct.", "Warning!");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
