using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Member_Update : Form
    {
        public Member_Update()
        {
            InitializeComponent();
        }

        public void loadMember(int memberId)
        {
            try
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Members WHERE MemberId=@memberId";
                    SQLiteCommand command = new SQLiteCommand(selectQuery, connection);

                    command.Parameters.AddWithValue("@memberId", memberId);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtMemberId.Text = dataTable.Rows[0][0].ToString();
                        txtFirstName.Text = dataTable.Rows[0][1].ToString();
                        txtLastName.Text = dataTable.Rows[0][2].ToString();
                        if (dataTable.Rows[0][3].ToString() == "Male")
                            radio_Male.Select();
                        else
                            radio_Female.Select();
                        dtpDOB.Value = DateTime.Parse(dataTable.Rows[0][4].ToString());
                        txtEmail.Text = dataTable.Rows[0][5].ToString();
                        txtPhone.Text = dataTable.Rows[0][6].ToString();
                        cmbMembershipType.Text = dataTable.Rows[0][8].ToString();
                        dtpJoinedDate.Value = DateTime.Parse(dataTable.Rows[0][7].ToString());
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "No member found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Member_Update_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            // Clear all form fields including the Member ID field
            txtFirstName.Clear();
            txtLastName.Clear();
            radio_Male.Checked = false;
            radio_Female.Checked = false;
            dtpDOB.Value = DateTime.Now;
            txtEmail.Clear();
            txtPhone.Clear();
            dtpJoinedDate.Value = DateTime.Now;
            cmbMembershipType.SelectedIndex = -1;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            int selectedMemberID = int.Parse(txtMemberId.Text);

            try
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE Members SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, DateOfBirth = @DateOfBirth, Email = @Email, Phone = @Phone, JoinDate = @JoinDate, MembershipType = @MembershipType WHERE MemberID = @MemberID";

                    SQLiteCommand command = new SQLiteCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@MemberID", selectedMemberID);
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);

                    // Get the gender value from the radio buttons
                    string gender = radio_Male.Checked ? "Male" : (radio_Female.Checked ? "Female" : null);
                    command.Parameters.AddWithValue("@Gender", gender);

                    command.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value.Date.ToShortDateString());
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@JoinDate", dtpJoinedDate.Value.Date.ToShortDateString());
                    command.Parameters.AddWithValue("@MembershipType", cmbMembershipType.SelectedItem.ToString());

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MetroMessageBox.Show(this, "Member details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Failed to update member details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
