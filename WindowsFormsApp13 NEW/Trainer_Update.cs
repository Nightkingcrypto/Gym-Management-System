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
    public partial class Trainer_Update : Form
    {
        public Trainer_Update()
        {
            InitializeComponent();
        }

        public void loadTrainer(int trainerId)
        {
            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Trainers WHERE TrainerId=@trainerId";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    command.Parameters.AddWithValue("@trainerId", trainerId);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtTrainerId.Text = dataTable.Rows[0][0].ToString();
                        txtFirstName.Text = dataTable.Rows[0][1].ToString();
                        txtLastName.Text = dataTable.Rows[0][2].ToString();
                        if (dataTable.Rows[0][3].ToString() == "Male")
                            radio_Male.Select();
                        else
                            radio_Female.Select();
                        dtpDOB.Value = DateTime.Parse(dataTable.Rows[0][4].ToString());
                        txtEmail.Text = dataTable.Rows[0][5].ToString();
                        txtPhone.Text = dataTable.Rows[0][6].ToString();
                        txtSpecialization.Text = dataTable.Rows[0][7].ToString();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No trainer found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTrainerDetails()
        {

            txtFirstName.Clear();
            txtLastName.Clear();
            radio_Male.Checked = false;
            radio_Female.Checked = false;
            dtpDOB.Value = DateTime.Now;
            txtEmail.Clear();
            txtPhone.Clear();
            txtSpecialization.Clear();
        }

        private void Trainor_Update_Load(object sender, EventArgs e)
        {
        
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedTrainerID = int.Parse(txtTrainerId.Text);

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE Trainers SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, DateOfBirth = @DateOfBirth, Email = @Email, Phone = @Phone, Specialization = @Specialization WHERE TrainerID = @TrainerID";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@TrainerID", selectedTrainerID);
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);

                    // Get the gender value from the radio buttons
                    string gender = radio_Male.Checked ? "Male" : (radio_Female.Checked ? "Female" : null);
                    command.Parameters.AddWithValue("@Gender", gender);

                    command.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@Specialization", txtSpecialization.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trainer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update trainer details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
