using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement.CustomControls
{
    class CustomTextBox : TextBox
    {
        private bool hasFocus;
        public string PlaceHolderValue { get; set; }

        public CustomTextBox()
        {
            this.GotFocus += CustomTextBox_GotFocus;
            this.LostFocus += CustomTextBox_LostFocus;
            this.TextChanged += CustomTextBox_TextChanged;
        }

        public void SetPlaceHolderValue(string value)
        {
            PlaceHolderValue = value;
            Text = PlaceHolderValue;
        }

        private void CustomTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!hasFocus)
            {
                CustomTextBox_LostFocus(null, null);
            }
        }

        public void CustomTextBox_GotFocus(object sender, EventArgs e)
        {
            hasFocus = true;
            if (Text == PlaceHolderValue)
            {
                Text = string.Empty;
            }
        }

        public void CustomTextBox_LostFocus(object sender, EventArgs e)
        {
            hasFocus = false;
            if (string.IsNullOrWhiteSpace(Text))
            {
                Text = PlaceHolderValue;
            }
        }

    }
}
