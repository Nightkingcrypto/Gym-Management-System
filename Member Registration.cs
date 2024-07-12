using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Member_Registration : Form
    {
        public Member_Registration()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txt_first.Clear();
            txt_last.Clear();
            radio_male.Checked = false;
            radio_female.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
            txt_email.Clear();
            txt_contact.Clear();
            dateTimePicker2.Value = DateTime.Today;
            comboBox1.SelectedIndex = -1;
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string firstName = txt_first.Text;
            string lastName = txt_last.Text;
            string gender = (radio_male.Checked) ? "Male" : "Female";
            string DateOfBirth = dateTimePicker1.Value.Date.ToShortDateString();
            string email = txt_email.Text;
            string phone = txt_contact.Text;
            string joinDate = dateTimePicker2.Value.Date.ToShortDateString();
            string membershipType = "";


            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    membershipType = "Standard";
                    break;
                case 1:
                    membershipType = "Premium";
                    break;
                case 2:
                    membershipType = "Short Term";
                    break;
                case 3:
                    membershipType = "Personal";
                    break;
                default:
                    break;
            }

            try
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();


                    string insertQuery = "INSERT INTO Members (FirstName, LastName, Gender, DateOfBirth, Email, Phone, JoinDate, MembershipType) " +
                        "VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @Email, @phone, @joinDate, @MembershipType)";
                    SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@joinDate", joinDate);
                    command.Parameters.AddWithValue("@MembershipType", membershipType);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MetroMessageBox.Show(this, "Member Registered Successfully!");
                        Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Failed to register member. Please try again.");
                    }

                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "An error occurred: " + ex.Message);
            }
        }
    }
    
}
