using MetroFramework;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp13
{
    public partial class DataViewer : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private string dataTableName = string.Empty;

        public DataViewer()
        {
            InitializeComponent();
        }

        private void loadTrainers(bool silent = false)
        {

            try
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Trainers";
                    SQLiteCommand command = new SQLiteCommand(selectQuery, connection);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.Columns.Clear();
                    label7.Text = "Showing Trainers Data";
                    dataTableName = "Trainers";

                    if (dataTable.Rows.Count > 0)
                    {
                        bindingSource1.DataSource = dataTable;
                        dataGridView1.DataSource = bindingSource1;
                    }
                    else
                    {
                        if (!silent)
                            MetroMessageBox.Show(this, "No trainers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (!silent)
                    MetroMessageBox.Show(this, "An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadMembers(bool silent = false)
        {

            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            try
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Members";
                    SQLiteCommand command = new SQLiteCommand(selectQuery, connection);

                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                   
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DateTime date = DateTime.Parse(dataTable.Rows[i]["JoinDate"].ToString());
                        if (date.CompareTo(startDate) < 0 || date.CompareTo(endDate) > 0)
                        {
                            dataTable.Rows.RemoveAt(i);
                        }
                    }

                    dataGridView1.Columns.Clear();
                    label7.Text = "Showing Members Data";
                    dataTableName = "Members";

                    if (dataTable.Rows.Count > 0)
                    {
                        bindingSource1.DataSource = dataTable;
                        dataGridView1.DataSource = bindingSource1;
                    }
                    else
                    {
                        if (!silent)
                            MetroMessageBox.Show(this, "No members found between the selected start and end dates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                    connection.Dispose();
                }

            }
            catch (Exception ex)
            {
                if (!silent)
                    MetroMessageBox.Show(this, "An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadEquipments(bool silent = false)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            try
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Equipments";
                    SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DateTime date = DateTime.Parse(dataTable.Rows[i]["DateOfPurchase"].ToString());
                        if (date.CompareTo(startDate) < 0 || date.CompareTo(endDate) > 0)
                        {
                            dataTable.Rows.RemoveAt(i);
                        }
                    }

                    dataGridView1.Columns.Clear();
                    label7.Text = "Showing Equipments Data";
                    dataTableName = "Equipments";

                    if (dataTable.Rows.Count > 0)
                    {
                        bindingSource1.DataSource = dataTable;
                        dataGridView1.DataSource = bindingSource1;
                    }
                    else
                    {
                        if (!silent)
                            MetroMessageBox.Show(this, "No equipment found between the selected start and end dates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (!silent)
                    MetroMessageBox.Show(this, "An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpStartDate.Value.Date.AddDays(-7);
            dbConnection db = new dbConnection();
            db.checkDataBaseAvailability();
        }

        private void loadPayments(bool silent = false)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            try
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Payments";
                    SQLiteCommand command = new SQLiteCommand(selectQuery, connection);

                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DateTime date = DateTime.Parse(dataTable.Rows[i]["PaymentDate"].ToString());
                        if (date.CompareTo(startDate) < 0 || date.CompareTo(endDate) > 0)
                        {
                            dataTable.Rows.RemoveAt(i);
                        }
                    }

                    dataGridView1.Columns.Clear();
                    label7.Text = "Showing Payment Data";
                    dataTableName = "Payments";

                    if (dataTable.Rows.Count > 0)
                    {
                        bindingSource1.DataSource = dataTable;
                        dataGridView1.DataSource = bindingSource1;
                    }
                    else
                    {
                        if (!silent)
                            MetroMessageBox.Show(this, "No payments found between the selected start and end dates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (!silent)
                    MetroMessageBox.Show(this, "An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            loadPayments();
        }

        private void btnViewMembes_Click(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void btnViewTrainers_Click(object sender, EventArgs e)
        {
            loadTrainers();
        }

        private void btnViewEquip_Click(object sender, EventArgs e)
        {
            loadEquipments();
        }

        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            NewPayment new_payment = new NewPayment();
            new_payment.ShowDialog();
            loadPayments(true);
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Member_Registration member_Registration = new Member_Registration();
            member_Registration.ShowDialog();
            loadMembers(true);
        }

        private void btnNewTrainer_Click(object sender, EventArgs e)
        {
            Trainer_Registration trainer_Registration = new Trainer_Registration();
            trainer_Registration.ShowDialog();
            loadTrainers(true);
        }

        private void btnNewEquipment_Click(object sender, EventArgs e)
        {
            Equipment_Registration equipment_Registration = new Equipment_Registration();
            equipment_Registration.ShowDialog();
            loadEquipments(true);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string ColumnName = dataGridView1.Columns[0].Name;

            if (dataTableName == "Members")
            {
                Member_Update memberEditForm = new Member_Update();
                memberEditForm.loadMember(int.Parse(Id));
                memberEditForm.ShowDialog();
                loadMembers(true);
            }
            else if (dataTableName == "Trainers")
            {
                Trainer_Update trainer_UpdateForm = new Trainer_Update();
                trainer_UpdateForm.loadTrainer(int.Parse(Id));
                trainer_UpdateForm.ShowDialog();
                loadTrainers(true);
            }
            else if (dataTableName == "Equipments")
            {
                Equipment_Update trainer_UpdateForm = new Equipment_Update();
                trainer_UpdateForm.loadEquiment(int.Parse(Id));
                trainer_UpdateForm.ShowDialog();
                loadEquipments(true);
            }
            else if (dataTableName == "Payments")
            {
                MetroMessageBox.Show(this, "Payments can't be edited.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string ColumnName = dataGridView1.Columns[0].Name;

            DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 
            if (result == DialogResult.Yes)
            {
                dbConnection db = new dbConnection();
                using (SQLiteConnection connection = db.initConnection())
                {
                    connection.Open();

                    string insertQuery = "DELETE FROM " + dataTableName + " WHERE " + ColumnName + "=@column";

                    SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@column", Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MetroMessageBox.Show(this, "Successfully deleted the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Failed to delete the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                    connection.Dispose();
                }
                if (dataTableName == "Members")
                {
                    loadMembers(true);
                }
                else if (dataTableName == "Trainers")
                {
                    loadTrainers(true);
                }
                else if (dataTableName == "Equipments")
                {
                    loadEquipments(true);
                }
                else if (dataTableName == "Payments")
                {
                    loadPayments(true);
                }
            }
        }
    }

}
