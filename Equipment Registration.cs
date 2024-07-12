using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Close();
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
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Equipments (Name, Price, DateOfPurchase, Quantity, Other) " +
                                   "VALUES (@EquipmentName, @Price, @DateOfPurchase, @Quantity, @other)";

                    SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@EquipmentName", equipmentname);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@DateOfPurchase", dateOfPurchase);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@other", other);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MetroMessageBox.Show(this, "Equipment Registered Successfully!");
                        Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Failed to register equipment. Please try again.");
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