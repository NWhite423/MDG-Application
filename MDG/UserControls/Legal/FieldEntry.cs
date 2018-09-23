using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Forms.Legal;
using MDG.Objects;

namespace MDG.UserControls.Legal
{
    public partial class FieldEntry : UserControl
    {
        public FieldEntry()
        {
            InitializeComponent();
        }

        public int Concern { get; set; }
        public int Index { get; set; }
        public NewContract masterForm { get; set; }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            CreateEntry form = new CreateEntry();
            form.txtContent.Text = txtItem.Text;
            form.txtTitle.Text = LblTitle.Text;

            DialogResult result = form.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                LblTitle.Text = form.txtTitle.Text;
                txtItem.Text = form.txtContent.Text;
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to remove this clause?\n\nNOTE:\nThis action is permanent.", "Are you sure", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (Concern == 0)
                {
                    masterForm.SoWEntries.RemoveAt(Index);
                    Functions.UpdateTableItems(masterForm, 1);
                }
                else
                {
                    masterForm.EexspenseEntries.RemoveAt(Index);
                    Functions.UpdateTableItems(masterForm, 2);
                }
            }
        }
    }
}
