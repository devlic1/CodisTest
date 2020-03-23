namespace UserManagement.Forms
{
    partial class UserList
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblUserGrid = new System.Windows.Forms.Label();
            this.txtFirstName = new UserManagement.CustomControls.CustomTextBox();
            this.txtLastName = new UserManagement.CustomControls.CustomTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 60);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(819, 461);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(714, 31);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(117, 23);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblUserGrid
            // 
            this.lblUserGrid.AutoSize = true;
            this.lblUserGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserGrid.Location = new System.Drawing.Point(12, 34);
            this.lblUserGrid.Name = "lblUserGrid";
            this.lblUserGrid.Size = new System.Drawing.Size(119, 17);
            this.lblUserGrid.TabIndex = 2;
            this.lblUserGrid.Text = "Users Information";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(234, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceHolderValue = null;
            this.txtFirstName.Size = new System.Drawing.Size(90, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(330, 31);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceHolderValue = null;
            this.txtLastName.Size = new System.Drawing.Size(86, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(422, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(503, 31);
            this.btnClearSearch.Name = "btnClear";
            this.btnClearSearch.Size = new System.Drawing.Size(96, 23);
            this.btnClearSearch.TabIndex = 6;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 533);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblUserGrid);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UserList";
            this.Text = "User List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblUserGrid;
        private CustomControls.CustomTextBox txtFirstName;
        private CustomControls.CustomTextBox txtLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
    }
}

