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
    public partial class Trainer_Registration : Form
    {
        public Trainer_Registration()
        {
            InitializeComponent();
        }


        private void Trainor_Registration_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
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
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Trainers (FirstName, LastName, Gender, DateOfBirth, Email, Phone, Specialization) " +
                                   "VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @Email, @phone, @Specialization)";

                    SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
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
                        MetroMessageBox.Show(this, "Trainer Registered Successfully!");
                        Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Failed to register trainer. Please try again.");
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
