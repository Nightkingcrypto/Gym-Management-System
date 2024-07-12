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
    public partial class Equipment_Registration : Form
    {
        public Equipment_Registration()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string equipmentname = txt_name.Text;
            string price = txt_value.Text;
            string dateOfPurchase = dateTimePicker1.Value.Date.ToShortDateString();
            string quantity = txt_qty.Text;
            string other = txt_other.Text;

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Equipments (Name, Price, DateOfPurchase, Quantity, Other ) " +
                                   "VALUES (@EquipmentName, @Price, @DateOfPurchase, @Quantity, @other)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@EquipmentName", equipmentname);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@DateOfPurchase", dateOfPurchase);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@other", other);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Equipment Registered Successfully!");

                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register equipment. Please try again.");
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

            txt_name.Clear();
            txt_value.Clear();
            dateTimePicker1.Value = DateTime.Today;
            txt_qty.Clear();
            txt_other.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}