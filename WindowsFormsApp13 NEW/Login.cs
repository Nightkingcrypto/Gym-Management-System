using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string enteredUsername = txt_username.Text;
            string enteredPassword = txt_password.Text;

            string correctUsername = "admin"; 
            string correctPassword = "1234"; 

            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                MessageBox.Show("Login Successful!");

                DataViewer mainForm = new DataViewer();
                mainForm.ShowDialog();
                
                this.Hide();
            }
            else
            {
               MessageBox.Show("Invalid username or password. Please try again.");
                
                txt_password.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
