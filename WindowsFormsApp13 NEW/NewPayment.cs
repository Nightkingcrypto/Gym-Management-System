using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp13
{
    public partial class NewPayment : Form
    {
        private DataTable members;

        public NewPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewPayment_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT MemberId, FirstName FROM Members";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    members = new DataTable();
                    dataAdapter.Fill(members);

                    for (int i = 0; i < members.Rows.Count; i++)
                    {
                        cmbMembers.Items.Add(members.Rows[i]["FirstName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string getMemberId()
            {
                for (int i = 0; i < members.Rows.Count; i++)
                {
                    if (members.Rows[i]["FirstName"].ToString() == cmbMembers.SelectedItem.ToString())
                    {
                        return members.Rows[i]["MemberId"].ToString();
                    }
                }
                return "";
            }

            string memberId = getMemberId();

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Payments (MemberId, PaymentAmount, PaymentDate) " +
                                   "VALUES (@memberId, @PaymentAmount, @PaymentDate)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@memberId", memberId);
                    command.Parameters.AddWithValue("@PaymentAmount", txtAmount.Text);
                    command.Parameters.AddWithValue("@PaymentDate", dateTimePicker1.Value.Date.ToShortDateString());

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payemnt Added Successfully!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add payment. Please try again.");
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
            cmbMembers.SelectedText = string.Empty;
            txtAmount.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

    }
}
