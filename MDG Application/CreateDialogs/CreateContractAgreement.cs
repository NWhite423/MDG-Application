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
using System.Diagnostics;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;

namespace MDG_Application.CreateDialogs
{
    public partial class CreateContractAgreement : Form
    {
        public CreateContractAgreement()
        {
            InitializeComponent();
        }

        private void cmdSelectSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Source File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceDoc.Text = dialog.FileName;
            }
        }

        private void cmdSelectOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDocumentOutput.Text = dialog.SelectedPath;
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            string fileName = txtDocumentOutput.Text + @"\Contract " + DateTime.Now.ToString("MM-dd-yyyy H-mm-ss") + ".doc";

            Debug.WriteLine(fileName);
            Debug.WriteLine("Calling writing function");
            CreateWordDocument(txtSourceDoc.Text, fileName);
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

                string addressLine = CustomerAddressLine1.Text + ", " + CustomerAddressLine2.Text + ", " + CustomerCity.Text + ", " + CustomerState.Text + " " + CustomerZip.Text;
                string addressSeperated = CustomerAddressLine1.Text + "\v" + CustomerAddressLine2.Text + "\v" + CustomerCity.Text + ", " + CustomerState.Text + " " + CustomerZip.Text;
                string CompanySignage = "______________________________\vAuthorized Agent";
                string now = DateTime.Now.ToString("dd MMMM yyyy");
                string[] dateArray = now.Split(' ');
                string date;
                switch (dateArray[0])
                {
                    case "01":
                        {
                            date = String.Format("{0}st day of {1}, {2}", dateArray[0], dateArray[1], dateArray[2]);
                            break;
                        }
                    case "02":
                        {
                            date = String.Format("{0}nd day of {1}, {2}", dateArray[0], dateArray[1], dateArray[2]);
                            break;
                        }
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
                foreach (ScopeOfWorkEntry Entry in PublicVariables.SoWItems)
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
                foreach (ExspenseEntry Entry in PublicVariables.ExpenseItems)
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
                this.FindAndReplace(aDoc, "<customer>", CustomerName.Text);
                this.FindAndReplace(aDoc, "<customerAddress>", addressLine);
                string currentBoard = Clipboard.GetText();
                Debug.WriteLine(ScopeOfWork);
                Clipboard.SetText(ScopeOfWork);
                this.FindAndReplace(aDoc, "<scopeofwork>", "^c");
                Debug.WriteLine(Exspenses);
                Clipboard.SetText(Exspenses);
                this.FindAndReplace(aDoc, "<expenses>", "^c");
                Clipboard.SetText(currentBoard);
                this.FindAndReplace(aDoc, "<customerinfo>", CustomerName.Text + "\v" + addressSeperated);
                if (rbCompany.Checked)
                {
                    this.FindAndReplace(aDoc, "<customersign>", CompanySignage);
                } else
                {
                    this.FindAndReplace(aDoc, "<customersign>", CustomerName.Text);
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
                wordApp.Visible=true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
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
                    Entry = form.Entry,
                    
                };
                if (form.Title == "")
                {
                    
                    entry.Title = "Item " + (PublicVariables.SoWItems.Count + 1).ToString();
                } else
                {
                    entry.Title = form.Title;
                }

                PublicVariables.SoWItems.Add(entry);
                Functions.PopulateSoWList(PanelSoW, PublicVariables.SoWItems);
            }
        }

        public static Panel PanelSoW { get; set; }
        public static Panel PanelExpenses { get; set; }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateContractAgreement_Load(object sender, EventArgs e)
        {
            PanelSoW = PnlSOW;
            PanelExpenses = PnlExspenses;
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
                    Entry = form.Entry,
                };
                if (form.Title == "")
                {
                    entry.Title = "Item " + (PublicVariables.ExpenseItems.Count + 1).ToString();
                }
                else
                {
                    entry.Title = form.Title;
                }

                PublicVariables.ExpenseItems.Add(entry);
                Functions.PopulateExpenseList(CreateContractAgreement.PanelExpenses, PublicVariables.ExpenseItems);
            }
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in Progress");
        }
    }
}
