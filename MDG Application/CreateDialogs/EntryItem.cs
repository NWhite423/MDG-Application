using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDG_Application.CreateDialogs
{
    public partial class EntryItem : UserControl
    {
        public EntryItem()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return LblTitle.Text;
            }
            set
            {
                LblTitle.Text = value;
            }
        }

        public string Item
        {
            get
            {
                return txtItem.Text;
            }
            set
            {
                txtItem.Text = value;
            }
        }

        public int Concern { get; set; }

        public int Index { get; set; }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            if (Concern == 0)
            {
                CreateEntry form = new CreateEntry();
                form.Title = PublicVariables.SoWItems[Index].Title;
                form.Entry = PublicVariables.SoWItems[Index].Entry;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.Title == "")
                    {

                        PublicVariables.SoWItems[Index].Title = "Item " + (PublicVariables.SoWItems.Count + 1).ToString();
                    }
                    else
                    {
                        PublicVariables.SoWItems[Index].Title = form.Title;
                    }


                    PublicVariables.SoWItems[Index].Entry = form.Entry;

                    Functions.PopulateSoWList(CreateContractAgreement.PanelSoW, PublicVariables.SoWItems);
                }
            } else
            {
                CreateEntry form = new CreateEntry();
                form.Title = PublicVariables.ExpenseItems[Index].Title;
                form.Entry = PublicVariables.ExpenseItems[Index].Entry;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.Title == "")
                    {

                        PublicVariables.ExpenseItems[Index].Title = "Item " + (PublicVariables.SoWItems.Count + 1).ToString();
                    }
                    else
                    {
                        PublicVariables.ExpenseItems[Index].Title = form.Title;
                    }


                    PublicVariables.ExpenseItems[Index].Entry = form.Entry;

                    Functions.PopulateExpenseList(CreateContractAgreement.PanelExpenses, PublicVariables.ExpenseItems);
                }
            }
            

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to remove this clause?\n\nNOTE:\nThis action is permanent.", "Are you sure", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (Concern == 0)
                {
                    PublicVariables.SoWItems.RemoveAt(Index);
                    Functions.PopulateSoWList(CreateContractAgreement.PanelSoW, PublicVariables.SoWItems);
                } else
                {
                    PublicVariables.ExpenseItems.RemoveAt(Index);
                    Functions.PopulateExpenseList(CreateContractAgreement.PanelExpenses, PublicVariables.ExpenseItems);
                }
                
            }
        }

        private void ScopeOfWorkItem_Load(object sender, EventArgs e)
        {
        
        }

        public bool UpArrowEnabled
        {
            get
            {
                return cmdMoveUp.Enabled;
            }
            set
            {
                cmdMoveUp.Enabled = value;
            }
        }

        public bool DownArrowEnabled
        {
            get
            {
                return cmdMoveDown.Enabled;
            }
            set
            {
                cmdMoveDown.Enabled = value;
            }
        }
    }
}
