using MetroFramework;
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string enteredUsername = txt_username.Text;
            string enteredPassword = txt_password.Text;

            string correctUsername = "admin";
            string correctPassword = "1234";

            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                Hide();
                DataViewer mainForm = new DataViewer();
                mainForm.ShowDialog();
                Close();

            }
            else
            {
                MetroMessageBox.Show(this, "Invalid username or password. Please try again.");

                txt_password.Clear();
            }
        }
    }
}
