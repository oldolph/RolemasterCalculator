using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RolemasterCalculator
{
    public partial class AddModifiers : Form
    {
        public AddModifiers()
        {
            InitializeComponent();
        }

        public int Value
        {
            get
            {
                return Convert.ToInt32(txtValue.Text);
            }
        }

        public string Description
        {
            get
            {
                return txtDesc.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            int val;

            if (txtValue.Text.Length > 0 && int.TryParse(txtValue.Text, out val))
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

    }
}
