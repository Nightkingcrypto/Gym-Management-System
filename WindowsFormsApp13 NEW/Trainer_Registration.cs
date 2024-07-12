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
    public partial class Trainer_Registration : Form
    {
        public Trainer_Registration()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string firstName = txt_first.Text;
            string lastName = txt_last.Text;
            string gender = (radio_male.Checked) ? "Male" : "Female"; 
            string dateOfBirth = dateTimePicker1.Value.Date.ToShortDateString();
            string email = txt_email.Text;
            string phone = txt_contact.Text;
            string specialization = txt_specialization.Text;

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Trainers (FirstName, LastName, Gender, DateOfBirth, Email, Phone, Specialization) " +
                                   "VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @Email, @phone, @Specialization)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@Specialization", specialization);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trainer Registered Successfully!");
                       
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register trainer. Please try again.");
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
            txt_specialization.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
      
            {
               
                this.Hide();
            }

        private void Trainor_Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
