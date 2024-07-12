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
    public partial class Equipment_Update : Form
    {
        public Equipment_Update()
        {
            InitializeComponent();
        }

        public void loadEquiment(int eqipId)
        {
            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Equipments WHERE EquipmentId=@equipmentId";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    command.Parameters.AddWithValue("@equipmentId", eqipId);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtEquipmentId.Text = dataTable.Rows[0][0].ToString();
                        txtEquipmentName.Text = dataTable.Rows[0][1].ToString();
                        txtPrice.Text = dataTable.Rows[0][2].ToString();
                        dtoPurchase.Value = DateTime.Parse(dataTable.Rows[0][3].ToString());
                        txtQuantity.Text = dataTable.Rows[0][4].ToString();
                        txtOther.Text = dataTable.Rows[0][5].ToString();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No equipment found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Equipment_update_Delete_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtEquipmentName.Text = string.Empty;
            txtOther.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            dtoPurchase.Value = DateTime.Now;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedMemberID = int.Parse(txtEquipmentId.Text);

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE Equipments SET Name = @Name, Price = @price, DateOfPurchase = @date, Quantity = @quantity, Other = @other WHERE EquipmentId = @id";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@id", selectedMemberID);
                    command.Parameters.AddWithValue("@Name", txtEquipmentName.Text);
                    command.Parameters.AddWithValue("@price", txtPrice.Text);
                    command.Parameters.AddWithValue("@date", dtoPurchase.Value.Date.ToShortDateString());
                    command.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    command.Parameters.AddWithValue("@other", txtOther.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Eqipment details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update equipment details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
