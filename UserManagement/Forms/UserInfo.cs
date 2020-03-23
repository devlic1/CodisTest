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
using UserManagement.DAL;
using UserManagement.Enums;
using UserManagement.Forms.Helpers;
using UserManagement.Models;

namespace UserManagement.Forms
{
    public partial class UserInfo : Form
    {
        private EntityAction entityAction;

        #region Properties
        public User User { get; set; }
        public IDataLogic dataLogic = null;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="action"></param>
        /// <param name="user"></param>
        public UserInfo(EntityAction action, User user)
        {
            InitializeComponent();

            entityAction = action;
            this.dataLogic = new FileDb();
            GridHelper.InitializeGrid<Address>(dgvAddresses);
            
            User = user;

            if (action == EntityAction.Edit)
            {
                PopulateInfo();
            }
            else
            {
                User = new User();
                User.PrimaryKey = Guid.NewGuid();
            }

            if (User.Addresses == null)
            {
                User.Addresses = new List<Address>();
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Populate form values from model
        /// </summary>
        private void PopulateInfo()
        {
            txtFirstName.Text = User.FirstName;
            txtLastName.Text = User.LastName;
            txtNickname.Text = User.NickName;
            dtpDOB.Value = User.DateOfBirth;

            dgvAddresses.DataSource = User.Addresses;
        }

        /// <summary>
        /// Checks if First Name and Last Name are unique for values already stored in database
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        private bool IsUserFirstNameLastNameUnique(List<User> users)
        {
            if (users
                .Where(x => x.PrimaryKey != User.PrimaryKey
                        && (x.FirstName.ToLower() == User.FirstName.ToLower()
                            && x.LastName.ToLower() == User.LastName.ToLower()))
                .Any()
            )
            {
                lblValidationErrors.Text = Messages.UserExistsWithName;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Save User information to database
        /// </summary>
        private void SaveUserInformation()
        {
            UpdateModelFromValues();

            if (!IsUserInfodValid())
            {
                return;
            }
            var users = dataLogic.GetAllUsers();

            if (!IsUserFirstNameLastNameUnique(users))
            {
                return;
            };

            if (entityAction == EntityAction.Edit)
            {
                var currentUser = users.Where(x => x.PrimaryKey == User.PrimaryKey).FirstOrDefault();
                currentUser.NickName = User.NickName;
                currentUser.FirstName = User.FirstName;
                currentUser.LastName = User.LastName;
                currentUser.DateOfBirth = User.DateOfBirth;

                currentUser.Addresses = User.Addresses;
            }
            else
            {
                users.Add(User);
            }

            dataLogic.SaveUsers(users);

            DialogResult = DialogResult.OK;
            MessageBox.Show(Messages.RecordSavedSuccessfully);
            Close();
        }

        /// <summary>
        /// Update model from form values 
        /// </summary>
        private void UpdateModelFromValues()
        {
            User.FirstName = txtFirstName.Text;
            User.LastName = txtLastName.Text;
            User.NickName = txtNickname.Text;
            User.DateOfBirth = dtpDOB.Value;
        }

        /// <summary>
        /// Checks if model is valid as per Data Annotations
        /// </summary>
        /// <returns></returns>
        private bool IsUserInfodValid()
        {
            bool isValid = false;

            if (!ValidationHelper.ValidateModel(User, out string errorString))
            {
                lblValidationErrors.Text = errorString.ToString();
            }
            else
            {
                isValid = true;
                lblValidationErrors.Text = string.Empty;
            }

            return isValid;
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Addresses data grid view Cell click event handler for handling Edit/Delete feature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAddresses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = (DataGridView)sender;
            Guid value = (Guid)dgv.Rows[e.RowIndex].Cells["PrimaryKey"].Value;

            if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show(Messages.SureToDelete, Messages.CaptionConfirm, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    User.Addresses.RemoveAll(x => x.PrimaryKey == value);
                    dgv.DataSource = User.Addresses.ToList();
                }
            }
            else if (e.ColumnIndex == 0)
            {
                var selectedAddress = User.Addresses.Where(x => x.PrimaryKey == value).FirstOrDefault();

                using (var addressForm = new AddressInfo(EntityAction.Edit, selectedAddress))
                {
                    addressForm.StartPosition = FormStartPosition.CenterParent;
                    var result = addressForm.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        var addresses = User.Addresses.ToList();
                        dgvAddresses.DataSource = addresses;
                    }
                }
            }
        }

        /// <summary>
        /// Event Handler for Saving User and related Addresses to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUserInformation();
        }

        /// <summary>
        /// Event handler for adding new address for user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewAddress_Click(object sender, EventArgs e)
        {
            using (var addressForm = new AddressInfo(EntityAction.Add, null))
            {
                addressForm.StartPosition = FormStartPosition.CenterParent;
                var result = addressForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    User.Addresses.Add(addressForm.CurrentAddressModel);
                    var addresses = User.Addresses.ToList();

                    dgvAddresses.DataSource = addresses;
                }
            }
        }
        #endregion
    }
}
