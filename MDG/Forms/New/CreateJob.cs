using MDG.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MDG.Forms.Common;
using MDG.UserControls;
using System.Diagnostics;

namespace MDG.Forms.New
{
    public partial class CreateJob : Form
    {
        public CreateJob()
        {
            InitializeComponent();
        }

        public CustomerClass Class { get; set; }
        
        private void CreateJob_Load(object sender, EventArgs e)
        {
            //Get Project Number
            string ProjectNumber = DateTime.Now.Year.ToString();
            ProjectNumber += "-" + (Directory.GetDirectories(Class.Path).Count()+1).ToString("D2");
            lblProjectNumber.Text = "Project Number: " + ProjectNumber;
            PublicVariables.JobForm = this;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BillableItem LineItem = new BillableItem();
            BillableItemForm Form = new BillableItemForm();
            DialogResult Result = Form.ShowDialog();
            if (Result.Equals(DialogResult.OK))
            {
                LineItem.Name = Form.txtTitle.Text;
                string Amount = Form.txtCount.Text;
                string Price = Form.txtPrice.Text;
                Debug.WriteLine("Amount: " + Amount + PublicVariables.NewLine + "Price: " + Price);
                LineItem.Amount = Convert.ToInt32(Amount);
                LineItem.Price = Convert.ToInt32(Price);
                PublicVariables.ItemList.Add(LineItem);
                Functions.PopulateList();
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            //Local defines.
            List<string> errors = new List<string> { };
            bool NeedLineItem = true;

            //Verify fields.
            foreach (Control control in this.Controls)
            {
                //Dont check disabled controls. Can't change them if you wanted to.
                if (control.Enabled)
                {
                    //If it is enabled but doesn't have a tag, it isn't a required field.
                    if ((control.Tag.ToString() != "Address Line 2") || (control is Button) || (control is Label) || (control is LineItem))
                    {
                        //If the control is a textbox.
                        if (control is TextBox)
                        {
                            var tb = (TextBox)control;
                            if (tb.Text == "")
                            {
                                errors.Add(String.Format("\n{0} is empty.", tb.Tag));
                            }
                        }
                        //control is a combobox
                        if (control is ComboBox)
                        {
                            var tb = (ComboBox)control;
                            if (tb.Text == "")
                            {
                                errors.Add("No representative is selected");
                            }
                        }
                        //No billable Items
                        if (control is LineItem) {
                            NeedLineItem = false;
                        }
                    }
                }
            }

            //If there are no billable item pt.2
            if (NeedLineItem)
            {
                errors.Add("\nthere are no billable Items. Please create at least one.");
            }

            //if there are errors, you cannot create an entry.
            if (errors.Count > 0)
            {
                string msg = "ERROR:\nThe following items need attention before a job can be created.\n";
                foreach (string error in errors)
                {
                    msg += error;
                }
                MessageBox.Show(msg, "INPUT ERROR");
                return;
            }

            //Create Job Entry.
            //Simple entries
            string ProjectNumber = DateTime.Now.Year.ToString();
            ProjectNumber += "-" + (Directory.GetDirectories(Class.Path).Count() + 1).ToString("D2");
            Job JobEntry = new Job();
            JobEntry.JobNumber = ProjectNumber;
            JobEntry.Name = txtProjectName.Text;
            JobEntry.Path = Class.Path + @"\" + ProjectNumber + " " + txtProjectName.Text;

            //Address
            JobEntry.Address.AddressLine1 = txtProjectAddress1.Text;
            JobEntry.Address.AddressLine2 = txtProjectAddress2.Text;
            JobEntry.Address.City = txtProjectCity.Text;
            JobEntry.Address.State = txtProjectState.Text;
            JobEntry.Address.Zip = txtProjectZip.Text;

            //Rep information
            if (cmbRepresentative.Enabled)
            {
                //Assumed to be a company, therefore we need a Point of Contact for this project.
                List<Representative> RepList = Class.Representatives;
                bool RepFound = false;
                int RepIndex = 0;
                while (!RepFound)
                {
                    Debug.WriteLine("Index: " + RepIndex.ToString());
                    Debug.WriteLine("Value: " + RepList[RepIndex].Name);
                    if (cmbRepresentative.GetItemText(cmbRepresentative.SelectedItem) == RepList[RepIndex].Name)
                    {
                        JobEntry.Representative = RepList[RepIndex];
                        RepFound = true;
                    }
                    RepIndex++;
                }
            } else
            {
                //Assumed to be a individual, which is the Point of Contact.
                JobEntry.Representative.Name = "";
                JobEntry.Representative.Phone = "";
                JobEntry.Representative.Email = "";
            }

            //Billable Items
            List<BillableItem> BillableItems = new List<BillableItem> { };
            foreach (Control contol in this.Controls)
            {
                if (contol is LineItem)
                {
                    var entry = (LineItem)contol;
                    BillableItems.Add(entry.ItemInfo);
                }
            }
            JobEntry.Items = BillableItems;

            string ConfirmString = String.Format("Are you sure you wish to create the following jobs?\nCustomer: {3}\n\tName: {0}\n\tRepresentative: {1}\n\tBillable Items: {2}", JobEntry.Name, JobEntry.Representative.Name, JobEntry.Items.Count, Class.Name);
            DialogResult result = MessageBox.Show(ConfirmString, "Create new Job", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                Functions.AddJobtoCustomer(Class, JobEntry);
                this.Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
