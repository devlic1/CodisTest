using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Enums;
using UserManagement.Forms.Helpers;
using UserManagement.Models;

namespace UserManagement.Forms
{
    public partial class AddressInfo : Form
    {
        #region Properties
        public Address CurrentAddressModel { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="action"></param>
        /// <param name="address"></param>
        public AddressInfo(EntityAction action, Address address)
        {
            InitializeComponent();
            CurrentAddressModel = address;

            cmbCountry.DataSource = Constants.Common.Countries;

            if (action == EntityAction.Edit)
            {
                PopulateInfo();
            }
            else
            {
                CurrentAddressModel = new Address();
                CurrentAddressModel.PrimaryKey = Guid.NewGuid();
            }
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Event handler for Saving Address for user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateModelFromValues();

            if (!IsAddressInfoValid())
            {
                return;
            }

            if (!IsAddressUniqueWithinUser())
            {
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Update model from form values 
        /// </summary>
        private void UpdateModelFromValues()
        {
            CurrentAddressModel.Line1 = txtLine1.Text.Trim();
            CurrentAddressModel.Line2 = txtLine2.Text.Trim();
            CurrentAddressModel.PostCode = txtPostCode.Text.Trim();
            CurrentAddressModel.Country = cmbCountry.SelectedItem.ToString();
        }

        /// <summary>
        /// Checks if model is valid as per Data Annotations
        /// </summary>
        /// <returns></returns>
        private bool IsAddressInfoValid()
        {
            bool isValid = false;

            if (!ValidationHelper.ValidateModel(CurrentAddressModel, out string errorString))
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

        /// <summary>
        /// Populate form values from model
        /// </summary>
        private void PopulateInfo()
        {
            txtLine1.Text = CurrentAddressModel.Line1;
            txtLine2.Text = CurrentAddressModel.Line2;
            txtPostCode.Text = CurrentAddressModel.PostCode;
            cmbCountry.SelectedItem = CurrentAddressModel.Country;
        }

        /// <summary>
        /// Checks if address is unique within user's addresses
        /// </summary>
        /// <returns></returns>
        private bool IsAddressUniqueWithinUser()
        {
            UserInfo userInfoForm = (UserInfo)Owner;

            if (userInfoForm.User.Addresses
                .Where(x => x.PrimaryKey != CurrentAddressModel.PrimaryKey && (
                    x.Line1.ToLower() == CurrentAddressModel.Line1.ToLower()
                    && x.Line2.ToLower() == CurrentAddressModel.Line2.ToLower()
                    && x.Country.ToLower() == CurrentAddressModel.Country.ToLower()
                    && x.PostCode.ToLower() == CurrentAddressModel.PostCode.ToLower()

            )).Any()
                )
            {
                lblValidationErrors.Text = Messages.AddressAlreadyExistsForUser;
                return false;
            }

            return true;
        }
        #endregion
    }
}
