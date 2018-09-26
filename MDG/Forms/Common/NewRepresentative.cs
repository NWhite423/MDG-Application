using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Objects;

namespace MDG.Forms.Common
{
    public partial class NewRepresentative : Form
    {
        public NewRepresentative()
        {
            InitializeComponent();
        }
        
        public Panel RepWindow { get; set; }
        public CustomerClass Customer { get; set; }
        public bool Modifing { get; set; }

        private void cmdSaveExit_Click(object sender, EventArgs e)
        {
            Representative representative = new Representative()
            {
                Name = txtName.Text,
                Title = txtTitle.Text,
                Phone = txtPhone.Text,
                Email = TxtEmail.Text
            };
            Functions.Modify.AddRepToCustomer(representative, Customer, RepWindow, Modifing);
            if (!Modifing)
            {
                Customer.Representatives.Add(representative);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdSaveClear_Click(object sender, EventArgs e)
        {
            Representative representative = new Representative()
            {
                Name = txtName.Text,
                Title = txtTitle.Text,
                Phone = txtPhone.Text,
                Email = TxtEmail.Text
            };
            Functions.Modify.AddRepToCustomer(representative, Customer, RepWindow, Modifing);
            if (!Modifing)
            {
                Customer.Representatives.Add(representative);
            }
            txtName.Text = "";
            txtTitle.Text = "";
            txtPhone.Text = "";
            TxtEmail.Text = "";
            txtName.Focus();
        }

        private void NewRepresentative_Load(object sender, EventArgs e)
        {
            if (Modifing)
            {
                cmdSaveClear.Enabled = false;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
