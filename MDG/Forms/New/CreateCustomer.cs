using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Objects;
using MDG.Forms.Common;
using System.IO;

namespace MDG.Forms.New
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();

        }

        /*private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            NewRepresentative form = new NewRepresentative();
            DialogResult result = form.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                string[] Entry = new string[] { form.RepName, form.Phone, form.Email };
                AddRepresentative(Entry);
            }
            else
            {
                if (result.Equals(DialogResult.Retry))
                {
                    string[] Entry = new string[] { form.RepName, form.Phone, form.Email };
                    AddRepresentative(Entry);
                    cmdAdd_Click(this, new EventArgs());
                }
            }
        }

        public List<Representative> Representatives = new List<Representative> { };

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //Verify fields are complete and make sense.
            List<string> ErrorItems = new List<string> { };

            //Go through all the textboxes serching for an empty box.
            // EXCEPTION: Address Line 2 is an optional field.
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (x.Text == "")
                    {
                        if (x.Tag.ToString() != "Address Line 2")
                        {
                            ErrorItems.Add(x.Tag.ToString());
                        }
                    }
                }
            }
            if (!rbCompany.Checked && !rbIndividual.Checked)
            {
                ErrorItems.Add("No category selected.");
            }
            //If the customer is a company, you need at least 1 point of reference.
            if (rbCompany.Checked)
            {
                if (lbReps.Items.Count == 0)
                {
                    ErrorItems.Add("Company Representatives");
                }
            }

            //If errors were found, tell the user and stop creating a customer.
            if (ErrorItems.Count > 0) {
                string missingItems = "";
                foreach (string Item in ErrorItems)
                {
                    missingItems += Item + "\n\t";
                }
                MessageBox.Show("ERROR:\nThe following fields are missing values. Please enter the appropriate value.\n\t" + missingItems, "Missing Items");
                return;
            }
            Debug.WriteLine("Fields valid. Moving on.");

            //Complete a CustomerClass object for storage.
            List<Job> EmptyJob = new List<Job> { };
            List<Representative> EmptyList = new List<Representative> { };
            
            CustomerClass Customer = new CustomerClass {
                Name = txtName.Text,
                Jobs = EmptyJob
            };
            if (rbCompany.Checked)
            {
                Customer.Representatives = Representatives;
                Customer.Category = "Company";
            }
            else
            {
                Customer.Representatives = EmptyList;
                Customer.Category = "Individual";
            }

            Customer.Address.AddressLine1 = txtAddress1.Text;
            Customer.Address.AddressLine2 = txtAddress2.Text;
            Customer.Address.City = txtCity.Text;
            Customer.Address.State = txtState.Text;
            Customer.Address.Zip = txtZip.Text;

            Customer.Path = Properties.Settings.Default.WorkDir + PublicVariables.Seperator + Customer.Name;

            bool Success = Functions.AddCustomer(Customer);    
            if (Success)
            {
                Functions.PopulateCustomers();
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        x.Text = "";
                    }
                }
                lbReps.Items.Clear();
            } 
        }
        
        public void AddRepresentative(string[] Values)
        {
            int index = lbReps.Items.Add(Values[0]);
            Representative Rep = new Representative
            {
                Name = Values[0],
                Phone = Values[1],
                Email = Values[2]
            };
            Representatives.Add(Rep);
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WorkDir == "")
            {
                DialogResult Result = MessageBox.Show("You have not set the work directory yet. Would you like to set the directory now?", "WORK DIRECTORY NOT SET", MessageBoxButtons.YesNo);
                if (Result.Equals(DialogResult.Yes))
                {
                    Properties.Settings.Default.WorkDir = Microsoft.VisualBasic.Interaction.InputBox("Please enter the directory you want.", "Work Directroy", "");
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("ERROR:\nNo work directory was found. Exiting.");
                    this.Close();
                    return;
                }
            }
        }*/
    }
}
