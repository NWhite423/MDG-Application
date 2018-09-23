using MDG.Objects;
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
using Microsoft.Office;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace MDG.Forms.Legal
{
    public partial class NewContract : Form
    {
        public NewContract()
        {
            InitializeComponent();
        }
        
        public List<ScopeOfWorkEntry> SoWEntries { get; set; }
        public List<ExspenseEntry> EexspenseEntries { get; set; }
        List<List<Job>> JobLists = new List<List<Job>> { };
        List<Address> Addresses = new List<Address> { };
        List<string> Paths = new List<string> { };
        CustomerClass CurrentCustomer = new CustomerClass();
        Job CurrentJob = new Job();
        
        private void cmdCreate_Click(object sender, EventArgs e)
        {
            string fileName = CurrentJob.Path + @"\Legal\Contract " + DateTime.Now.ToString("MM-dd-yyyy H-mm-ss") + ".doc";
            string sourceDoc = @"C:\Users\Nathan\Dropbox\Legal Documents\Independant Contractor Agreement Template.doc";

            Debug.WriteLine(fileName);
            Debug.WriteLine("Calling writing function");
            CreateWordDocument(sourceDoc, fileName);
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word._Document wDoc, string findText, string replaceWithText)
        {
            Microsoft.Office.Interop.Word.Range range = wDoc.Content;
            object missing = System.Reflection.Missing.Value;

            object findtext = findText;
            object f = false;
            object findreplacement = replaceWithText;
            object findforward = false;
            object findformat = true;
            object findwrap = WdFindWrap.wdFindContinue;
            object findmatchcase = false;
            object findmatchwholeword = false;
            object findmatchwildcards = false;
            object findmatchsoundslike = false;
            object findmatchallwordforms = false;
            object findreplace = WdReplace.wdReplaceAll;

            range.Find.Execute(
               findtext,
               findmatchcase,
               findmatchwholeword,
               findmatchwildcards,
               findmatchsoundslike,
               findmatchallwordforms,
               findforward,
               findwrap,
               findformat,
               findreplacement,
               findreplace,
               missing,
               missing,
               missing,
               missing);
        }
        
        private void CreateWordDocument(object fileName, object SaveAs)
        {
            object missing = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Word._Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word._Document aDoc = null;
            Debug.WriteLine("Checking file now.");
            if (File.Exists((string)fileName))
            {
                Debug.WriteLine("File found. Editing file.");
                DateTime Today = DateTime.Now;

                object docreadonly = false;
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref fileName, ref missing, ref docreadonly, ref missing,
                                                ref missing, ref missing, ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref isVisible, ref missing, ref missing,
                                                ref missing, ref missing);

                aDoc.Activate();

                string addressLine;
                string addressSeperated;
                if (CurrentCustomer.Address.AddressLine2 == "")
                {
                    addressLine = CurrentCustomer.Address.AddressLine1 + ", " + CurrentCustomer.Address.City + ", " + CurrentCustomer.Address.State + " " + CurrentCustomer.Address.Zip;
                    addressSeperated = CurrentCustomer.Address.AddressLine1 + "\v" + CurrentCustomer.Address.City + ", " + CurrentCustomer.Address.State + " " + CurrentCustomer.Address.Zip;
                } else
                {
                    addressLine = CurrentCustomer.Address.AddressLine1 + ", " + CurrentCustomer.Address.AddressLine2 + ", " + CurrentCustomer.Address.City + ", " + CurrentCustomer.Address.State + " " + CurrentCustomer.Address.Zip;
                    addressSeperated = CurrentCustomer.Address.AddressLine1 + "\v" + CurrentCustomer.Address.AddressLine2 + "\v" + CurrentCustomer.Address.City + ", " + CurrentCustomer.Address.State + " " + CurrentCustomer.Address.Zip;
                }
                string CompanySignage = "______________________________\vAuthorized Agent";
                string now = DateTime.Now.ToString("dd MMMM yyyy");
                string[] dateArray = now.Split(' ');
                string date;
                switch (dateArray[0])
                {
                    case "21":
                    case "31":
                    case "01":
                        {
                            date = String.Format("{0}st day of {1}, {2}", dateArray[0], dateArray[1], dateArray[2]);
                            break;
                        }
                    case "22":
                    case "02":
                        {
                            date = String.Format("{0}nd day of {1}, {2}", dateArray[0], dateArray[1], dateArray[2]);
                            break;
                        }
                    case "23":
                    case "03":
                        {
                            date = String.Format("{0}rd day of {1}, {2}", dateArray[0], dateArray[1], dateArray[2]);
                            break;
                        }
                    default:
                        {
                            date = String.Format("{0}th day of {1}, {2}", dateArray[0], dateArray[1], dateArray[2]);
                            break;
                        }
                }
                string ScopeOfWork = "";
                string Exspenses = "";
                int index = 0;
                foreach (ScopeOfWorkEntry Entry in SoWEntries)
                {
                    if (index == 0)
                    {
                        ScopeOfWork += Entry.Title + " \v" + Entry.Entry;
                        index++;
                    }
                    else
                    {
                        ScopeOfWork += "\r\n" + Entry.Title + " \v" + Entry.Entry;
                        index++;
                    }
                }

                index = 0;
                foreach (ExspenseEntry Entry in EexspenseEntries)
                {
                    if (index == 0)
                    {
                        Exspenses += Entry.Title + " \v" + Entry.Entry;
                        index++;
                    }
                    else
                    {
                        Exspenses += "\r\n" + Entry.Title + " \v" + Entry.Entry;
                        index++;
                    }
                }


                this.FindAndReplace(aDoc, "<date>", date);
                this.FindAndReplace(aDoc, "<customer>", CurrentCustomer.Name);
                this.FindAndReplace(aDoc, "<customerAddress>", addressLine);
                string currentBoard = Clipboard.GetText();
                Debug.WriteLine(ScopeOfWork);
                Clipboard.SetText(ScopeOfWork);
                this.FindAndReplace(aDoc, "<scopeofwork>", "^c");
                Debug.WriteLine(Exspenses);
                Clipboard.SetText(Exspenses);
                this.FindAndReplace(aDoc, "<expenses>", "^c");
                Clipboard.SetText(" ");
                this.FindAndReplace(aDoc, "<customerinfo>", CurrentCustomer.Name + "\v" + addressSeperated);
                if (CurrentCustomer.Category == "Company")
                {
                    this.FindAndReplace(aDoc, "<customersign>", CompanySignage);
                }
                else
                {
                    this.FindAndReplace(aDoc, "<customersign>", CurrentCustomer.Name);
                }
            }
            else
            {
                MessageBox.Show("Specified template does not exist...");
                return;
            }

            Debug.WriteLine("File edited. Saving as new file.");
            aDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing);

            Debug.WriteLine("File saved.");

            aDoc.Close(ref missing, ref missing, ref missing);


            var result = MessageBox.Show("Contract saved successfully.\nWould you like to view the file now?", "Open file", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                object docreadonly = false;
                object isVisible = true;
                wordApp = new Microsoft.Office.Interop.Word.Application();
                aDoc = wordApp.Documents.Open(ref SaveAs, ref missing, ref docreadonly, ref missing,
                                                ref missing, ref missing, ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref isVisible, ref missing, ref missing,
                                                ref missing, ref missing);
                wordApp.Visible = true;
            }
        }

        private void cmdSoWAdd_Click(object sender, EventArgs e)
        {
            CreateEntry form = new CreateEntry();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Debug.WriteLine(String.Format("Form exited with {0}", result.ToString()));
                ScopeOfWorkEntry entry = new ScopeOfWorkEntry
                {
                    Entry = form.txtContent.Text,

                };
                if (form.txtTitle.Text == "")
                {

                    entry.Title = "Item " + (SoWEntries.Count + 1).ToString();
                }
                else
                {
                    entry.Title = form.txtTitle.Text;
                }

                SoWEntries.Add(entry);
                Functions.UpdateTableItems(this, 1);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateContractAgreement_Load(object sender, EventArgs e)
        {
            SoWEntries = new List<ScopeOfWorkEntry> { };
            EexspenseEntries = new List<ExspenseEntry> { };

            foreach (CustomerClass customer in PublicVariables.CustomerList)
            {
                cmbCustomers.Items.Add(customer.Name);
                JobLists.Add(customer.Jobs);
            }
        }

        private void cmdExpenseAdd_Click(object sender, EventArgs e)
        {
            CreateEntry form = new CreateEntry();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Debug.WriteLine(String.Format("Form exited with {0}", result.ToString()));
                ExspenseEntry entry = new ExspenseEntry
                {
                    Entry = form.txtContent.Text,
                };
                if (form.txtTitle.Text == "")
                {
                    entry.Title = "Item " + (EexspenseEntries.Count + 1).ToString();
                }
                else
                {
                    entry.Title = form.txtTitle.Text;
                }

                EexspenseEntries.Add(entry);
                Functions.UpdateTableItems(this, 2);
            }
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in Progress");
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbJobs.Items.Clear();
            CurrentCustomer = PublicVariables.CustomerList[cmbCustomers.SelectedIndex];
            List<Job> jobItems = JobLists[cmbCustomers.SelectedIndex];
            foreach (Job job in jobItems)
            {
                int index = cmbJobs.Items.Add(job.Name);
                Addresses.Add(job.Address);
                Paths.Add(job.Path);
            }
        }

        private void cmbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Address address = Addresses[cmbJobs.SelectedIndex];
            CurrentJob = JobLists[cmbCustomers.SelectedIndex][cmbJobs.SelectedIndex];
            CustomerName.Text = cmbJobs.Text;
            CustomerAddressLine1.Text = address.AddressLine1;
            CustomerAddressLine2.Text = address.AddressLine2;
            CustomerCity.Text = address.City;
            CustomerState.Text = address.State;
            CustomerZip.Text = address.Zip;
        }
    }
}
