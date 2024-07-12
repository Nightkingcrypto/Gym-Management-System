using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
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


        private void NewPayment_Load(object sender, EventArgs e)
        {
            try
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT MemberId, FirstName FROM Members";
                    SQLiteCommand command = new SQLiteCommand(selectQuery, connection);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    members = new DataTable();
                    dataAdapter.Fill(members);

                    for (int i = 0; i < members.Rows.Count; i++)
                    {
                        cmbMembers.Items.Add(members.Rows[i]["FirstName"].ToString());
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


        private void metroButton1_Click(object sender, EventArgs e)
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
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Payments (MemberId, PaymentAmount, PaymentDate) " +
                                   "VALUES (@memberId, @PaymentAmount, @PaymentDate)";

                    SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@memberId", memberId);
                    command.Parameters.AddWithValue("@PaymentAmount", txtAmount.Text);
                    command.Parameters.AddWithValue("@PaymentDate", dateTimePicker1.Value.Date.ToShortDateString());

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MetroMessageBox.Show(this, "Payemnt Added Successfully!");
                        Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Failed to add payment. Please try again.");
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
