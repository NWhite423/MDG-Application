using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Objects;

namespace MDG.Forms.Common
{
    public partial class BillableItemForm : Form
    {
        public BillableItemForm()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (Functions.EntryIsDigits(txtCount.Text))
            {
                cmdSave.Enabled = true;
            } else
            {
                cmdSave.Enabled = false;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (Functions.EntryIsDigits(txtPrice.Text))
            {
                cmdSave.Enabled = true;
            }
            else
            {
                cmdSave.Enabled = false;
            }
        }
    }
}
