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
using MDG.Forms.Legal;

namespace MDG.UserControls.MainMenu
{
    public partial class JobForm : UserControl
    {
        public JobForm()
        {
            InitializeComponent();
        }

        public CustomerClass Class { get; set; }
        public Job CurrentJob { get; set; }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            Point position = new Point(0, cmdNew.Height);
            cmsNew.Show(cmdNew, position);
        }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            Point position = new Point(0, cmdModify.Height);
            cmsNew.Show(cmdModify, position);
        }

        private void cmdNewContract_Click(object sender, EventArgs e)
        {
            NewContract Form = new NewContract();
            Form.Show();
            Form.cmbCustomers.SelectedIndex = PublicVariables.CustomerList.IndexOf(Class);
            Form.cmbJobs.SelectedIndex = Class.Jobs.IndexOf(CurrentJob);
        }
    }
}
