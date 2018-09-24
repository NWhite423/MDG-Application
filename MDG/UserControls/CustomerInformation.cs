using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.UserControls;
using MDG.Forms.New;
using MDG.Objects;
using System.Diagnostics;

namespace MDG.UserControls
{
    public partial class CustomerInformation : UserControl
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public string Address
        {
            get
            {
                return lblAddress.Text;
            }
            set
            {
                lblAddress.Text = value;
            }
        }

        public CustomerClass Class { get; set; }

        private void cmdCreateJob_Click(object sender, EventArgs e)
        {
            CreateJob form = new CreateJob();
            form.txtCompanyName.Text = Class.Name;
            form.txtCompanyAddress1.Text = Class.Address.AddressLine1;
            form.txtCompanyAddress2.Text = Class.Address.AddressLine2;
            form.txtCompanyCity.Text = Class.Address.City;
            form.txtCompanyState.Text = Class.Address.State;
            form.txtCompanyZip.Text = Class.Address.Zip;
            form.txtCompanyName.Enabled = false;
            form.txtCompanyAddress1.Enabled = false;
            form.txtCompanyAddress2.Enabled = false;
            form.txtCompanyCity.Enabled = false;
            form.txtCompanyState.Enabled = false;
            form.txtCompanyZip.Enabled = false;
            if (Class.Category == "Individual")
            {
                form.cmbRepresentative.Enabled = false;
            }
            else
            {
                foreach (Representative Rep in Class.Representatives)
                {
                    form.cmbRepresentative.Items.Add(Rep.Name);
                }
                form.cmbRepresentative.SelectedIndex = 0;
            }
            form.Class = Class;
            form.Show();
        }

        private void lblCategory_TextChanged(object sender, EventArgs e)
        {
            if (Class.Category == "Individual")
            {
                cmdRep.Enabled = false;
                return;
            }
            if (Class.Category == "Company")
            {
                cmdRep.Enabled = true;
                return;
            }
        }
        
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you wish to delete" + lblTitle + "\nThis action is irreversable and cannot be recovered.\n\nTHE FILES WILL BE MOVED TO A BACKUP DIRECTORY.", "Are you sure?", MessageBoxButtons.YesNo);
            if (Result.Equals(DialogResult.Yes))
            {
                Functions.RemoveCustomer(Class);
                Functions.PopulateCustomers();
            }
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            Functions.ShowInformation(Class, 1);
        }

        private void cmdOpenFileLocation_Click(object sender, EventArgs e)
        {
            Process.Start(Class.Path);
        }

        private void cmdJobs_Click(object sender, EventArgs e)
        {
            Functions.ShowInformation(Class, 2);
        }
    }
}
