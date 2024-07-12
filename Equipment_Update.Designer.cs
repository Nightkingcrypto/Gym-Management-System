namespace WindowsFormsApp13
{
    partial class Equipment_Update
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtEquipmentId = new System.Windows.Forms.Label();
            this.btn_submit = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dtoPurchase = new MetroFramework.Controls.MetroDateTime();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtOther = new MetroFramework.Controls.MetroTextBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtEquipmentName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(501, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "LKR";
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.AutoSize = true;
            this.txtEquipmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentId.Location = new System.Drawing.Point(245, 51);
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.Size = new System.Drawing.Size(51, 20);
            this.txtEquipmentId.TabIndex = 70;
            this.txtEquipmentId.Text = "label8";
            // 
            // btn_submit
            // 
            this.btn_submit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_submit.Location = new System.Drawing.Point(416, 303);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(127, 37);
            this.btn_submit.TabIndex = 82;
            this.btn_submit.Text = "Update";
            this.btn_submit.UseSelectable = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(269, 303);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(127, 37);
            this.metroButton1.TabIndex = 81;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dtoPurchase
            // 
            this.dtoPurchase.Location = new System.Drawing.Point(249, 164);
            this.dtoPurchase.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtoPurchase.Name = "dtoPurchase";
            this.dtoPurchase.Size = new System.Drawing.Size(228, 29);
            this.dtoPurchase.TabIndex = 80;
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(249, 211);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(185, 23);
            this.txtQuantity.TabIndex = 79;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOther
            // 
            // 
            // 
            // 
            this.txtOther.CustomButton.Image = null;
            this.txtOther.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txtOther.CustomButton.Name = "";
            this.txtOther.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOther.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOther.CustomButton.TabIndex = 1;
            this.txtOther.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOther.CustomButton.UseSelectable = true;
            this.txtOther.CustomButton.Visible = false;
            this.txtOther.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOther.Lines = new string[0];
            this.txtOther.Location = new System.Drawing.Point(249, 246);
            this.txtOther.MaxLength = 32767;
            this.txtOther.Name = "txtOther";
            this.txtOther.PasswordChar = '\0';
            this.txtOther.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOther.SelectedText = "";
            this.txtOther.SelectionLength = 0;
            this.txtOther.SelectionStart = 0;
            this.txtOther.ShortcutsEnabled = true;
            this.txtOther.Size = new System.Drawing.Size(294, 23);
            this.txtOther.TabIndex = 78;
            this.txtOther.UseSelectable = true;
            this.txtOther.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOther.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(249, 128);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(247, 23);
            this.txtPrice.TabIndex = 77;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEquipmentName
            // 
            // 
            // 
            // 
            this.txtEquipmentName.CustomButton.Image = null;
            this.txtEquipmentName.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txtEquipmentName.CustomButton.Name = "";
            this.txtEquipmentName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEquipmentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEquipmentName.CustomButton.TabIndex = 1;
            this.txtEquipmentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEquipmentName.CustomButton.UseSelectable = true;
            this.txtEquipmentName.CustomButton.Visible = false;
            this.txtEquipmentName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEquipmentName.Lines = new string[0];
            this.txtEquipmentName.Location = new System.Drawing.Point(249, 92);
            this.txtEquipmentName.MaxLength = 32767;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.PasswordChar = '\0';
            this.txtEquipmentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEquipmentName.SelectedText = "";
            this.txtEquipmentName.SelectionLength = 0;
            this.txtEquipmentName.SelectionStart = 0;
            this.txtEquipmentName.ShortcutsEnabled = true;
            this.txtEquipmentName.Size = new System.Drawing.Size(294, 23);
            this.txtEquipmentName.TabIndex = 76;
            this.txtEquipmentName.UseSelectable = true;
            this.txtEquipmentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEquipmentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(57, 211);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 75;
            this.metroLabel5.Text = "Quantity";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(57, 250);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 74;
            this.metroLabel4.Text = "Other";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(57, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 73;
            this.metroLabel3.Text = "Purchase Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(57, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(147, 19);
            this.metroLabel2.TabIndex = 72;
            this.metroLabel2.Text = "Value/ Purchased Price";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(57, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 71;
            this.metroLabel1.Text = "Equipment Name";
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(57, 303);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(127, 37);
            this.metroButton2.TabIndex = 83;
            this.metroButton2.Text = "Clear";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(57, 51);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 19);
            this.metroLabel6.TabIndex = 84;
            this.metroLabel6.Text = "Equipment Id";
            // 
            // Equipment_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 373);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtoPurchase);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtEquipmentId);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Equipment_Update";
            this.Text = "Equipment Data Update";
            this.Load += new System.EventHandler(this.Equipment_update_Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtEquipmentId;
        private MetroFramework.Controls.MetroButton btn_submit;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroDateTime dtoPurchase;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroTextBox txtOther;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtEquipmentName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}