using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
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
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Members (FirstName, LastName, Gender, DateOfBirth, Email, Phone, JoinDate, MembershipType) " +
                        "VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @Email, @phone, @joindate, @MembershipType)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@joinDate", joinDate);
                    command.Parameters.AddWithValue("@MembershipType", membershipType);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine(firstName + ' ' + lastName + ' ' + gender + ' ' + DateOfBirth + ' ' + email + ' ' + phone + ' ' + joinDate+ ' ' + membershipType);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Member Registered Successfully!");

                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register member. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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

        private void btn_back_Click(object sender, EventArgs e)
       
            {
                
                this.Hide();
            }
    }
    
}
