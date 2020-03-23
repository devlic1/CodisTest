namespace UserManagement.Forms
{
    partial class UserInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNicname = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dgvAddresses = new System.Windows.Forms.DataGridView();
            this.lblUserAddresses = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblValidationErrors = new System.Windows.Forms.Label();
            this.btnAddNewAddress = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(141, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(116, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(141, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(116, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(141, 94);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(116, 20);
            this.txtNickname.TabIndex = 2;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(14, 145);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 19);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // lblNicname
            // 
            this.lblNicname.AutoSize = true;
            this.lblNicname.Location = new System.Drawing.Point(14, 101);
            this.lblNicname.Name = "lblNicname";
            this.lblNicname.Size = new System.Drawing.Size(55, 13);
            this.lblNicname.TabIndex = 8;
            this.lblNicname.Text = "Nickname";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(141, 138);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(116, 20);
            this.dtpDOB.TabIndex = 9;
            // 
            // dgvAddresses
            // 
            this.dgvAddresses.AllowUserToAddRows = false;
            this.dgvAddresses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddresses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddresses.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAddresses.Location = new System.Drawing.Point(16, 222);
            this.dgvAddresses.Name = "dgvAddresses";
            this.dgvAddresses.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddresses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAddresses.ShowEditingIcon = false;
            this.dgvAddresses.Size = new System.Drawing.Size(448, 150);
            this.dgvAddresses.TabIndex = 10;
            this.dgvAddresses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddresses_CellClick);
            // 
            // lblUserAddresses
            // 
            this.lblUserAddresses.AutoSize = true;
            this.lblUserAddresses.Location = new System.Drawing.Point(14, 198);
            this.lblUserAddresses.Name = "lblUserAddresses";
            this.lblUserAddresses.Size = new System.Drawing.Size(81, 13);
            this.lblUserAddresses.TabIndex = 11;
            this.lblUserAddresses.Text = "User Addresses";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblValidationErrors
            // 
            this.lblValidationErrors.AutoSize = true;
            this.lblValidationErrors.ForeColor = System.Drawing.Color.Red;
            this.lblValidationErrors.Location = new System.Drawing.Point(288, 19);
            this.lblValidationErrors.MaximumSize = new System.Drawing.Size(180, 180);
            this.lblValidationErrors.Name = "lblValidationErrors";
            this.lblValidationErrors.Size = new System.Drawing.Size(0, 13);
            this.lblValidationErrors.TabIndex = 13;
            // 
            // btnAddNewAddress
            // 
            this.btnAddNewAddress.Location = new System.Drawing.Point(353, 193);
            this.btnAddNewAddress.Name = "btnAddNewAddress";
            this.btnAddNewAddress.Size = new System.Drawing.Size(111, 23);
            this.btnAddNewAddress.TabIndex = 14;
            this.btnAddNewAddress.Text = "Add New Addess";
            this.btnAddNewAddress.UseVisualStyleBackColor = true;
            this.btnAddNewAddress.Click += new System.EventHandler(this.btnAddNewAddress_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.ForeColor = System.Drawing.Color.Crimson;
            this.lblInformation.Location = new System.Drawing.Point(19, 388);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(447, 13);
            this.lblInformation.TabIndex = 15;
            this.lblInformation.Text = "*Address changes like Add/Edit/Delete will be saved to database along with User I" +
    "nformation";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 445);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnAddNewAddress);
            this.Controls.Add(this.lblValidationErrors);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUserAddresses);
            this.Controls.Add(this.dgvAddresses);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblNicname);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblNicname;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DataGridView dgvAddresses;
        private System.Windows.Forms.Label lblUserAddresses;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblValidationErrors;
        private System.Windows.Forms.Button btnAddNewAddress;
        private System.Windows.Forms.Label lblInformation;
    }
}