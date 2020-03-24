using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Constants;
using UserManagement.DAL;
using UserManagement.Enums;
using UserManagement.Forms;
using UserManagement.Forms.Helpers;
using UserManagement.Models;

namespace UserManagement.Forms
{
    public partial class UserList : Form
    {
        IDataLogic dataLogic = null;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public UserList()
        {
            InitializeComponent();
            this.CenterToScreen();

            dataLogic = new FileDb();

            GridHelper.InitializeGrid<User>(dgvUsers);
            dgvUsers.Columns["DateOfBirth"].DefaultCellStyle.Format = Common.DateOfBirthFormat;

            txtFirstName.SetPlaceHolderValue(Messages.FirstNamePlaceholderValue);
            txtLastName.SetPlaceHolderValue(Messages.LastNamePlaceholderValue);

            RefreshGridData();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Binds data to grid
        /// </summary>
        private void RefreshGridData()
        {
            var users = dataLogic.GetAllUsers();
            dgvUsers.DataSource = users;
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Users data grid view cell click event for handling Edit/Delete feature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = (DataGridView)sender;
            Guid value = (Guid)dgv.Rows[e.RowIndex].Cells["PrimaryKey"].Value;

            if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show(Messages.SureToDelete, Messages.CaptionConfirm, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    dataLogic.RemoveUser(value);
                    dgv.DataSource = dataLogic.GetAllUsers();
                }

            }
            else if (e.ColumnIndex == 0)
            {
                var selectedUser = dataLogic.GetUserInfo(value);

                using (var userForm = new UserInfo(EntityAction.Edit, selectedUser))
                {
                    userForm.StartPosition = FormStartPosition.CenterParent;
                    DialogResult result = userForm.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        RefreshGridData();
                    }
                }
            }
        }

        /// <summary>
        /// Add new User button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using (var userForm = new UserInfo(EntityAction.Add, null))
            {
                userForm.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = userForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    RefreshGridData();
                }
            }
        }

        /// <summary>
        /// Search button click event to filter results on exact match of first name and last name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text.Trim()) && string.IsNullOrWhiteSpace(txtLastName.Text.Trim())
                || (txtFirstName.Text == txtFirstName.PlaceHolderValue && txtLastName.Text == txtLastName.PlaceHolderValue))
            {
                MessageBox.Show(Messages.EnterValueToSearch, Messages.CaptionInformation);
                return;
            }

            var users = dataLogic.GetAllUsers();

            var filteredUsers = users.Where(x => x.FirstName.ToLower() == txtFirstName.Text.Trim().ToLower() && x.LastName.ToLower() == txtLastName.Text.Trim().ToLower()).ToList();
            if (filteredUsers.Count > 0)
            {
                dgvUsers.DataSource = filteredUsers;
            }
            else
            {
                string firstNameText = txtFirstName.Text == txtFirstName.PlaceHolderValue ? string.Empty : txtFirstName.Text.Trim();
                string lastNameText = txtLastName.Text == txtLastName.PlaceHolderValue ? string.Empty : txtLastName.Text.Trim();

                MessageBox.Show(string.Format(Messages.NoUsersFoundWithFirstNameLastName, firstNameText, lastNameText), Messages.CaptionInformation);
            }
        }

        /// <summary>
        /// Clear Search button click to clear textbox values and refresh grid data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            RefreshGridData();
        }
        #endregion
    }
}
