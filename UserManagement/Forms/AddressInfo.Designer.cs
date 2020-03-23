namespace UserManagement.Forms
{
    partial class AddressInfo
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
            this.PostCode = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblValidationErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PostCode
            // 
            this.PostCode.AutoSize = true;
            this.PostCode.Location = new System.Drawing.Point(28, 150);
            this.PostCode.Name = "PostCode";
            this.PostCode.Size = new System.Drawing.Size(53, 13);
            this.PostCode.TabIndex = 0;
            this.PostCode.Text = "PostCode";
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Location = new System.Drawing.Point(28, 30);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(33, 13);
            this.lblLine1.TabIndex = 1;
            this.lblLine1.Text = "Line1";
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Location = new System.Drawing.Point(28, 70);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(33, 13);
            this.lblLine2.TabIndex = 2;
            this.lblLine2.Text = "Line2";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(28, 107);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country";
            // 
            // txtLine1
            // 
            this.txtLine1.Location = new System.Drawing.Point(106, 27);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(121, 20);
            this.txtLine1.TabIndex = 4;
            // 
            // txtLine2
            // 
            this.txtLine2.Location = new System.Drawing.Point(106, 67);
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.Size = new System.Drawing.Size(121, 20);
            this.txtLine2.TabIndex = 5;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(106, 147);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(121, 20);
            this.txtPostCode.TabIndex = 6;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(106, 104);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbCountry.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblValidationErrors
            // 
            this.lblValidationErrors.AutoSize = true;
            this.lblValidationErrors.ForeColor = System.Drawing.Color.Red;
            this.lblValidationErrors.Location = new System.Drawing.Point(256, 34);
            this.lblValidationErrors.MaximumSize = new System.Drawing.Size(180, 180);
            this.lblValidationErrors.Name = "lblValidationErrors";
            this.lblValidationErrors.Size = new System.Drawing.Size(0, 13);
            this.lblValidationErrors.TabIndex = 9;
            // 
            // AddressInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 240);
            this.Controls.Add(this.lblValidationErrors);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtLine2);
            this.Controls.Add(this.txtLine1);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.PostCode);
            this.Name = "AddressInfo";
            this.Text = "AddressInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PostCode;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtLine1;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblValidationErrors;
    }
}