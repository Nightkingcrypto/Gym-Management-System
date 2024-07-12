namespace WindowsFormsApp13
{
    partial class DataViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MessageBox = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpStartDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpEndDate = new MetroFramework.Controls.MetroDateTime();
            this.btnViewPayments = new MetroFramework.Controls.MetroButton();
            this.btnViewMembes = new MetroFramework.Controls.MetroButton();
            this.btnViewTrainers = new MetroFramework.Controls.MetroButton();
            this.btnViewEquip = new MetroFramework.Controls.MetroButton();
            this.btnNewPayment = new MetroFramework.Controls.MetroButton();
            this.btnNewMember = new MetroFramework.Controls.MetroButton();
            this.btnNewTrainer = new MetroFramework.Controls.MetroButton();
            this.btnNewEquipment = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.AutoSize = true;
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.Location = new System.Drawing.Point(438, 436);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(0, 17);
            this.MessageBox.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(423, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 25);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "FROM";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(497, 33);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(221, 29);
            this.dtpStartDate.TabIndex = 16;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(797, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 25);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "TO";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(848, 33);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(221, 29);
            this.dtpEndDate.TabIndex = 18;
            // 
            // btnViewPayments
            // 
            this.btnViewPayments.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnViewPayments.Location = new System.Drawing.Point(332, 93);
            this.btnViewPayments.Name = "btnViewPayments";
            this.btnViewPayments.Size = new System.Drawing.Size(173, 45);
            this.btnViewPayments.TabIndex = 19;
            this.btnViewPayments.Text = "VIEW PAYMENTS";
            this.btnViewPayments.UseSelectable = true;
            this.btnViewPayments.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // btnViewMembes
            // 
            this.btnViewMembes.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnViewMembes.Location = new System.Drawing.Point(520, 93);
            this.btnViewMembes.Name = "btnViewMembes";
            this.btnViewMembes.Size = new System.Drawing.Size(173, 45);
            this.btnViewMembes.TabIndex = 20;
            this.btnViewMembes.Text = "VIEW MEMBERS";
            this.btnViewMembes.UseSelectable = true;
            this.btnViewMembes.Click += new System.EventHandler(this.btnViewMembes_Click);
            // 
            // btnViewTrainers
            // 
            this.btnViewTrainers.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnViewTrainers.Location = new System.Drawing.Point(709, 93);
            this.btnViewTrainers.Name = "btnViewTrainers";
            this.btnViewTrainers.Size = new System.Drawing.Size(173, 45);
            this.btnViewTrainers.TabIndex = 21;
            this.btnViewTrainers.Text = "VIEW TRAINERS";
            this.btnViewTrainers.UseSelectable = true;
            this.btnViewTrainers.Click += new System.EventHandler(this.btnViewTrainers_Click);
            // 
            // btnViewEquip
            // 
            this.btnViewEquip.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnViewEquip.Location = new System.Drawing.Point(896, 93);
            this.btnViewEquip.Name = "btnViewEquip";
            this.btnViewEquip.Size = new System.Drawing.Size(173, 45);
            this.btnViewEquip.TabIndex = 22;
            this.btnViewEquip.Text = "VIEW EQUIPMENT";
            this.btnViewEquip.UseSelectable = true;
            this.btnViewEquip.Click += new System.EventHandler(this.btnViewEquip_Click);
            // 
            // btnNewPayment
            // 
            this.btnNewPayment.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNewPayment.Location = new System.Drawing.Point(36, 41);
            this.btnNewPayment.Name = "btnNewPayment";
            this.btnNewPayment.Size = new System.Drawing.Size(162, 35);
            this.btnNewPayment.TabIndex = 23;
            this.btnNewPayment.Text = "New Payment";
            this.btnNewPayment.UseSelectable = true;
            this.btnNewPayment.Click += new System.EventHandler(this.btnNewPayment_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNewMember.Location = new System.Drawing.Point(36, 91);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(162, 35);
            this.btnNewMember.TabIndex = 24;
            this.btnNewMember.Text = "New Member";
            this.btnNewMember.UseSelectable = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnNewTrainer
            // 
            this.btnNewTrainer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNewTrainer.Location = new System.Drawing.Point(36, 139);
            this.btnNewTrainer.Name = "btnNewTrainer";
            this.btnNewTrainer.Size = new System.Drawing.Size(162, 35);
            this.btnNewTrainer.TabIndex = 25;
            this.btnNewTrainer.Text = "New Trainer";
            this.btnNewTrainer.UseSelectable = true;
            this.btnNewTrainer.Click += new System.EventHandler(this.btnNewTrainer_Click);
            // 
            // btnNewEquipment
            // 
            this.btnNewEquipment.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNewEquipment.Location = new System.Drawing.Point(36, 190);
            this.btnNewEquipment.Name = "btnNewEquipment";
            this.btnNewEquipment.Size = new System.Drawing.Size(162, 35);
            this.btnNewEquipment.TabIndex = 26;
            this.btnNewEquipment.Text = "New Equipment";
            this.btnNewEquipment.UseSelectable = true;
            this.btnNewEquipment.Click += new System.EventHandler(this.btnNewEquipment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(36, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 330);
            this.dataGridView1.Style = MetroFramework.MetroColorStyle.Silver;
            this.dataGridView1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label7.Location = new System.Drawing.Point(766, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Click on the above button to view data";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(474, 610);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(219, 25);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Select a row to start actions";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdate.Location = new System.Drawing.Point(720, 610);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 35);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.Location = new System.Drawing.Point(907, 610);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 35);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DataViewer
            // 
            this.ClientSize = new System.Drawing.Size(1104, 658);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewEquipment);
            this.Controls.Add(this.btnNewTrainer);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.btnNewPayment);
            this.Controls.Add(this.btnViewEquip);
            this.Controls.Add(this.btnViewTrainers);
            this.Controls.Add(this.btnViewMembes);
            this.Controls.Add(this.btnViewPayments);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MessageBox);
            this.MinimumSize = new System.Drawing.Size(1120, 697);
            this.Name = "DataViewer";
            this.Text = "Data Viewer";
            this.Load += new System.EventHandler(this.NewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label MessageBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtpStartDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpEndDate;
        private MetroFramework.Controls.MetroButton btnViewPayments;
        private MetroFramework.Controls.MetroButton btnViewMembes;
        private MetroFramework.Controls.MetroButton btnViewTrainers;
        private MetroFramework.Controls.MetroButton btnViewEquip;
        private MetroFramework.Controls.MetroButton btnNewPayment;
        private MetroFramework.Controls.MetroButton btnNewMember;
        private MetroFramework.Controls.MetroButton btnNewTrainer;
        private MetroFramework.Controls.MetroButton btnNewEquipment;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
    }
}