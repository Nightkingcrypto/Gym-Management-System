using System;
using System.Data;
using System.Data.SqlClient;
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }



        private void btnViewTrainers1_Click(object sender, EventArgs e)
        {
            loadTrainers();
        }

        private void loadTrainers(bool silent = false)
        {

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Trainers";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
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
                            System.Windows.Forms.MessageBox.Show("No trainers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (!silent)
                    System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void loadMembers(bool silent = false)
        {

            string startDate = dtpStartDate.Value.Date.ToShortDateString();
            string endDate = dtpEndDate.Value.Date.ToShortDateString();

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Members WHERE JoinDate BETWEEN @StartDate AND @EndDate";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

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
                            System.Windows.Forms.MessageBox.Show("No members found between the selected start and end dates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (!silent)
                    System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnViewEquipment_Click(object sender, EventArgs e)
        {
            loadEquipments();
        }

        private void loadEquipments(bool silent = false)
        {
            string startDate = dtpStartDate.Value.Date.ToShortDateString();
            string endDate = dtpEndDate.Value.Date.ToShortDateString();

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Equipments WHERE DateOfPurchase BETWEEN @StartDate AND @EndDate";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

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
                            System.Windows.Forms.MessageBox.Show("No equipment found between the selected start and end dates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (!silent)
                    System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = dtpStartDate.Value.Date.AddDays(-7);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            if (rows.Count == 1)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string ColumnName = dataGridView1.Columns[0].Name;

            DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string insertQuery = "DELETE FROM " + dataTableName + " WHERE " + ColumnName + "=@column";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@column", Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Successfully deleted the record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Failed to delete the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void btnUpdate_Click(object sender, EventArgs e)
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
                System.Windows.Forms.MessageBox.Show("Payments can't be edited.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewPayment new_payment = new NewPayment();
            new_payment.ShowDialog();
            loadPayments(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Member_Registration member_Registration = new Member_Registration();
            member_Registration.ShowDialog();
            loadMembers(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Trainer_Registration trainer_Registration = new Trainer_Registration();
            trainer_Registration.ShowDialog();
            loadTrainers(true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Equipment_Registration equipment_Registration = new Equipment_Registration();
            equipment_Registration.ShowDialog();
            loadEquipments(true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadPayments();
        }

        private void loadPayments(bool silent = false)
        {
            string startDate = dtpStartDate.Value.Date.ToShortDateString();
            string endDate = dtpEndDate.Value.Date.ToShortDateString();

            try
            {
                using (SqlConnection connection = dbConnection.GetSqlConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Payments WHERE PaymentDate BETWEEN @StartDate AND @EndDate";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

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
                            System.Windows.Forms.MessageBox.Show("No payments found between the selected start and end dates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (!silent)
                    System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
